using LibrarySystem;

var library = new Library();

library.AddBook(new Book("Crime and Punishment", "Fyodor Dostoevsky", 1886));
library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
library.AddBook(new Book("1984", "George Orwell", 1949));
library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 1813));
library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
library.AddBook(new Book("Moby-Dick", "Herman Melville", 1851));
library.AddBook(new Book("The Lord of the Rings", "J.R.R. Tolkien", 1954));
library.AddBook(new Book("To the Lighthouse", "Virginia Woolf", 1927));
library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));

library.RemoveBook(3);

library.RemoveBook("Moby-Dick");

library.FindBook("Brave New World");

Console.WriteLine("\n\n");

for (int i = 0; i < library.Count; i++)
{
    library[i].OutputBookInfo();
}

