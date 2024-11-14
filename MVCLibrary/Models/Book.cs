﻿using Microsoft.AspNetCore.Mvc;

namespace MVCLibrary.Models
{
    public class Book 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}
