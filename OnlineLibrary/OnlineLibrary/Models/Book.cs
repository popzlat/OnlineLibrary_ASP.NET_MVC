namespace OnlineLibrary.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }
        public int Quantity { get; set; }


       public void  IncraseQuantity( int aditionalQuantity)
            {
            var currentQuantity = this.Quantity;
            Quantity = aditionalQuantity + currentQuantity;

            }

       public void RemoveCopy( int removedCopy)
        {
            var currentQuantity = this.Quantity;
            Quantity = currentQuantity - removedCopy;

        }
        

        public Book(int id,string isbn,string name,GenreEnum genre, string description,Author author,int pages,int quantity)
        {
            this.Id = id;
            this.Isbn = isbn;
            this.Name = name;
            this.Genre = genre;
            this.Author = author;
            this.Pages = pages;
            this.Quantity = quantity;
        }


    }
}
