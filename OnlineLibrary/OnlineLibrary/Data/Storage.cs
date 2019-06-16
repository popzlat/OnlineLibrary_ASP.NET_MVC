using OnlineLibrary.Models;
using System.Collections.Generic;
namespace OnlineLibrary.Data
{
    public static class Storage
    {

        public static List<Author> Authors = new List<Author>
        {

            new Author (1,"Orson","Scott"),
            new Author(2,"Truman","Capote"),
            new Author(3,"Graeme","Simsion"),

        };
        public static List<Book> Books = new List<Book>
        {
            new Book (1,"0-312-93208-1","Ender's Game",GenreEnum.SciFi,"DescriptionEnder's Game is a 1985 military science fiction novel by American author Orson Scott Card. Set at an unspecified date in Earth's future, the novel presents an imperiled humankind after two conflicts with the Formics, an insectoid alien species they dub the buggers.",Authors[0],324,5),
            new Book(2,"0-679-74558-0","In Cold Blood",GenreEnum.Crime,"In Cold Blood is a non-fiction novel by American author Truman Capote, first published in 1966; it details the 1959 murders of four members of the Herbert Clutter family in the small farming community of Holcomb, Kansas.",Authors[1],343,10),
            new Book(3,"9781922079770","The Rosie Project",GenreEnum.Comedy,"Don Tillman is an Australian genetics professor who has spent his days organizing his life with the expectation that it will reduce inefficiency, improve himself as a person, and make him an all around happier person.",Authors[2],304,15)
        };


        public static Library NewLibrary = new Library("My Library",Books);
        
    }
}
