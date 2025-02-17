﻿using Microsoft.AspNetCore.Mvc;
using Task_Manager_Backend.Data;

namespace Task_Manager_Backend.Services
{
    public class EmployeeServices 
    {
        public readonly AppDbContext appDbContext;

        public EmployeeServices(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IResult> AddEmployee(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            await appDbContext.SaveChangesAsync();
            return Results.Ok(employee);
        }
    }
}
