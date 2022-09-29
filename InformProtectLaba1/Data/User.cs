﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformProtectLaba1.Data;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public bool isBlocked { get; set; }
    public bool isPasswordConstraint { get; set; }
    public string Role { get; set; } = "user";

}
