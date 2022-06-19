using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GamaWebSitesi.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public String Name { get; set; }
        public String SurName { get; set; }
    }
}