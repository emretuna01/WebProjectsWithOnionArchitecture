﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Features.Commands.InsertCrmUser
{
    public class InsertCrmUserCommandRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}