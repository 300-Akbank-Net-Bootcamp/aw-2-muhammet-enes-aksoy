using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vb.Data;
using Vb.Data.Entity;


namespace VbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StaffController : ControllerBase
{
     private readonly VbDbContext dbContext;

    public StaffController(VbDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<List<Staff>> Get()
    {
        return await dbContext.Set<Staff>()
            .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<Staff> Get(int id)
    {
        var staff =  await dbContext.Set<Staff>()
            .Include(x=> x.Name)
            .Include(x=> x.Email)
            .Where(x => x.Id == id).FirstOrDefaultAsync();
       
        return staff;
    }

    [HttpPost]
    public async Task Post([FromBody] Staff staff)
    {
        await dbContext.Set<Staff>().AddAsync(staff);
        await dbContext.SaveChangesAsync();
    }

    [HttpPut("{id}")]
    public async Task Put(int id, [FromBody] Staff staff)
    {
        var fromdb = await dbContext.Set<Staff>().Where(x => x.Id == id).FirstOrDefaultAsync();
        fromdb.Name = staff.Name;
        fromdb.Email = staff.Email;

        await dbContext.SaveChangesAsync();
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        var fromdb = await dbContext.Set<Staff>().Where(x => x.Id == id).FirstOrDefaultAsync();
        fromdb.IsActive = false;
        await dbContext.SaveChangesAsync();
    }
}