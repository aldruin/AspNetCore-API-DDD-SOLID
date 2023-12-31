﻿using CashFlowAPI.Domain.Entities;
using CashFlowAPI.Domain.ValueObjects;

namespace CashFlowAPI.Application.Dtos;
public class UserDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public Password Password { get; set; }
    //public List<Sheet>? Sheets { get; set; }
    public List<string>? Sheets { get; set; }
}