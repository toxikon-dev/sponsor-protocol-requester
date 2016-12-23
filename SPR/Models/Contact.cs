using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPR.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int SponsorCode { get; set; }

        public Contact()
        {
            this.Name = "Matthew Condit";
            this.Code = "0";
            this.Phone = "607-745-0570";
            this.Email = "matt.condit@outlook.com";
            this.SponsorCode = 1;
        }
    }
}