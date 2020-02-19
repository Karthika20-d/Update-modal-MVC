﻿using System;
namespace OnlineRealEstateEntity
{
    public enum Location
    {
        Erode,
        Salem,
        Chennai,
        Bangalore,
        Hyderabad
    }
    public class UserManager
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public Location location { get; set; }
     
    }
   
}
