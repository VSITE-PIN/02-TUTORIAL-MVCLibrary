namespace MVCLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   // obavezno
        public string ISBN { get; set; }    // obavezno
        public string Author { get; set; }  // novo polje, obavezno
    }
}
