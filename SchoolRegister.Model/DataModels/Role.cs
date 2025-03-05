using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModels;

public class Role : IdentityRole<int>
{
    public RoleValue RoleValue {  get; set; }
    
    public Role() { }

    public Role(string name, RoleValue roleValue)
    {
        RoleValue = roleValue;
    }
}

public enum RoleValue
{
    User,
    Student,
    Parent,
    Teacher,
    Admin
}