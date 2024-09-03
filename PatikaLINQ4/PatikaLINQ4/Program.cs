using System;
using System.Security.Cryptography.X509Certificates;
using PatikaLINQ4;
public class Program
{
    public static void Main()
    {

        //yazarlar listesine nesneler ekleme
        var authors = new List<Author>()
       {
          new Author {Id=1, Name="Orhan Pamuk"},
          new Author {Id=2, Name="Elif Şafak"},
          new Author {Id=3, Name="Ahmet Ümit"}
       };


        //kitaplar listesine nesneler ekleme
        var books = new List<Book>()
        {
            new Book {AuthorId=1, Title="Kar", BookId=1},
            new Book {AuthorId=1, Title="Istanbul", BookId=2},
            new Book {AuthorId=2, Title="10 Minutes 38 Seconds In This Strange World", BookId=3},
            new Book {AuthorId=3, Title="Beyoğlu Rapsodisi", BookId=4}
        };

        // İki listeyi Join ile birleştirme
        var bookWithAuthors = authors.Join(books,
                                     author => author.Id,
                                     book => book.AuthorId,
                                     (author, book) => new
                                     {
                                         BookName = book.Title,
                                         AuthorName = author.Name,

                                     });



        foreach (var item in bookWithAuthors) 
        {
            Console.WriteLine($"Yazarın adı : {item.AuthorName} - Yazarın kitabı: {item.BookName}");
            Console.WriteLine("*****");

        }

        


    }
}