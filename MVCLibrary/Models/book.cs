using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCLibrary.Models
{
    public class Book
    {
        public int id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string Author { get; set; }

    }
}
