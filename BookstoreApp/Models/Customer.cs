﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";
        
        public string Email { get; set; } = "";


        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
                
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} {Email}";
        }
    }
}
