﻿using Microsoft.AspNetCore.Http;
using PrivateSquares.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace PrivateSquares.Services.Utilities
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
