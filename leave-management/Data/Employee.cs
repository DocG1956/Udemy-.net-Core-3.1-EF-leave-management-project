using Microsoft.AspNetCore.Identity;
using System;

namespace leave_management.Data
{
    public class Employee : IdentityUser //Inheriting IdentityUser will add these columns to the AspnetUser table which was autocreated during project creation
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }

    }
}
