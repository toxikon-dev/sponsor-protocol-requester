using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPR.Models
{
    public class Request
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string SponsorCode { get; set; }
        public string RequestedBy { get; set; }
        public string ContactCode { get; set; }
        public string DateRequested { get; set; }
        public string Status { get; set; }

        public Request()
        {
            this.ID = 0;
            this.Description = "USP 201";
            this.SponsorCode = "100";
            this.RequestedBy = "Matthew Condit";
            this.DateRequested = DateTime.Now.ToString("d");
            this.Status = "Pending";
        }
    }
}