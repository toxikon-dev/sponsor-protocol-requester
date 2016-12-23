using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPR.Models
{
    public class Sponsor
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Request> OpenRequests;
        public List<Contact> Contacts;
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PONumber { get; set; }

        public string getFullAddress() {
            return this.Address + ", \n" + this.City + " " + this.State + " " + this.ZipCode;
        }


        public Sponsor()
        {
            this.Name = "Toxikon";
            this.Code = "0";
            this.OpenRequests = new List<Request>();
            this.Contacts = new List<Contact>();
            this.Address = "17 Hickory Lane";
            this.City = "Cortland";
            this.State = "NY";
            this.ZipCode = "13045";
            this.PONumber = "";
        }
    }
}