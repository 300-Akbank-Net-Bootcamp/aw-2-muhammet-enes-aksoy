using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vb.Data;
using Vb.Data.Entity;

namespace VbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
     private readonly VbDbContext dbContext;

    public EmployeeController(VbDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<List<Employee>> Get()
    {
        return await dbContext.Set<Employee>()
            .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<Employee> Get(int id)
    {
        var employee =  await dbContext.Set<Employee>()
            .Include(x=> x.DateOfBirth)
            .Include(x=> x.Name)
            .Include(x=> x.Email)
            .Where(x => x.Id == id).FirstOrDefaultAsync();
       
        return employee;
    }

    [HttpPost]
    public async Task Post([FromBody] Employee employee)
    {
        await dbContext.Set<Employee>().AddAsync(employee);
        await dbContext.SaveChangesAsync();
    }

    [HttpPut("{id}")]
    public async Task Put(int id, [FromBody] Employee employee)
    {
        var fromdb = await dbContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefaultAsync();
        fromdb.Name = employee.Name;
        fromdb.Email = employee.Email;

        await dbContext.SaveChangesAsync();
    }

    [HttpDelete("{id}")]
    public async Task Delete(int id)
    {
        var fromdb = await dbContext.Set<Employee>().Where(x => x.Id == id).FirstOrDefaultAsync();
        fromdb.IsActive = false;
        await dbContext.SaveChangesAsync();
    }
}