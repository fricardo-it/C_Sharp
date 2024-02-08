﻿using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidConcepts._1_SPP.SPP_Solving
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string SIN { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool IsValid() 
        {
            return EmailServices.IsValid(Email) && SINServices.IsValid(SIN);   
        }

    }
}
