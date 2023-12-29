# Customer Management System

## Overview

Customer Management System is a .NET Core application designed to manage customer information, addresses, contact details, and accounts. It provides a set of APIs for basic CRUD operations on entities such as Customer, Address, Contact, Account, Account Transaction, and EFT Transaction.

## Features

- **Customer Entity:**
  - Manages basic customer information.
  - Associated with addresses, contact details, and accounts.

- **Address Entity:**
  - Stores customer address information.
  - Includes details like address type, country, city, postal code, etc.

- **Contact Entity:**
  - Manages customer contact information.
  - Includes contact type, phone number, email, etc.

- **Account Entity:**
  - Handles customer account information.
  - Includes account number, IBAN, balance, currency type, etc.

- **Account Transaction Entity:**
  - Tracks transactions associated with an account.
  - Includes reference number, transaction date, amount, etc.

- **EFT Transaction Entity:**
  - Represents Electronic Funds Transfer (EFT) transactions.
  - Includes sender account, sender IBAN, sender name, etc.


## API Endpoints

### Customers:

![Screenshot_5](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/c0decd91-af0c-453c-aff1-9e5f4de9a821)

- **GET /api/customers:**
  - Retrieves a list of all customers.

- **GET /api/customers/{id}:**
  - Retrieves a customer by their ID.

- **POST /api/customers:**
  - Creates a new customer.

- **PUT /api/customers/{id}:**
  - Updates a customer identified by their ID.

- **DELETE /api/customers/{id}:**
  - Deletes a customer identified by their ID.

### Addresses:

![Screenshot_2](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/439e83f3-7909-4a8c-a8ce-ed6b253db3ab)

- **GET /api/addresses:**
  - Retrieves a list of all addresses.

- **GET /api/addresses/{id}:**
  - Retrieves an address by its ID.

- **POST /api/addresses:**
  - Creates a new address.

- **PUT /api/addresses/{id}:**
  - Updates an address identified by its ID.

- **DELETE /api/addresses/{id}:**
  - Deletes an address identified by its ID.

### Contacts:

![Screenshot_4](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/05314eca-76b7-4dc9-aef7-f31ae5522f6e)

- **GET /api/contacts:**
  - Retrieves a list of all contact details.

- **GET /api/contacts/{id}:**
  - Retrieves a contact detail by its ID.

- **POST /api/contacts:**
  - Creates a new contact detail.

- **PUT /api/contacts/{id}:**
  - Updates a contact detail identified by its ID.

- **DELETE /api/contacts/{id}:**
  - Deletes a contact detail identified by its ID.

### Accounts:

![Screenshot_0](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/650a3533-3f7a-4af3-9e59-90cc3e35b2bb)

- **GET /api/accounts:**
  - Retrieves a list of all accounts.

- **GET /api/accounts/{id}:**
  - Retrieves an account by its ID.

- **POST /api/accounts:**
  - Creates a new account.

- **PUT /api/accounts/{id}:**
  - Updates an account identified by its ID.

- **DELETE /api/accounts/{id}:**
  - Deletes an account identified by its ID.

### Account Transactions:

![Screenshot_1](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/85d1e2f5-e7b9-4e0b-bf4a-411f928019c4)

- **GET /api/accounttransactions:**
  - Retrieves a list of all account transactions.

- **GET /api/accounttransactions/{id}:**
  - Retrieves an account transaction by its ID.

- **POST /api/accounttransactions:**
  - Creates a new account transaction.

- **PUT /api/accounttransactions/{id}:**
  - Updates an account transaction identified by its ID.

- **DELETE /api/accounttransactions/{id}:**
  - Deletes an account transaction identified by its ID.

### EFT Transactions:

![Screenshot_6](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/8e77e62b-44ca-4273-961e-784e8436c527)


- **GET /api/efttransactions:**
  - Retrieves a list of all EFT transactions.

- **GET /api/efttransactions/{id}:**
  - Retrieves an EFT transaction by its ID.

- **POST /api/efttransactions:**
  - Creates a new EFT transaction.

- **PUT /api/efttransactions/{id}:**
  - Updates an EFT transaction identified by its ID.

- **DELETE /api/efttransactions/{id}:**
  - Deletes an EFT transaction identified by its ID.

## Database Tables

![Screenshot_7](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/5ae29129-d31c-40d6-a4c7-5ec9d3ec1c69)

## Example Get Methods

![Screenshot_3](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/f0adf403-70a4-43b6-8f39-1b283b8630cd)

![Screenshot_8](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/11a1647a-5bed-45db-9303-2645d25fcd72)

![Screenshot_9](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/90063888-1b14-4105-8cc6-132b4bb9475b)


## Example Delete Methods

![Screenshot_10](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/6b856e21-3083-4456-86bc-2e9f4325dfaa)

![Screenshot_11](https://github.com/300-Akbank-Net-Bootcamp/aw-2-muhammet-enes-aksoy/assets/97848966/5c9b2f90-4396-4b14-9d8d-fe4b5bf72435)

Database isAcvite status turned 0.

## Technologies Used

- **ASP.NET Core Web API:** Framework for building HTTP services.
- **Entity Framework Core:** Object-Relational Mapping (ORM) for database interaction.
- **C# Programming Language:** Primary language for development.
- **Microsoft SQL Server:** Database for storing customer and transactional data.


