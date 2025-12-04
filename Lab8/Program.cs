using System;

class Book
{
    public string Name;
    public int ReleaseYear;
    public bool Taken;

    public Book(string name, int year)
    {
        Name = name;
        ReleaseYear = year;
        Taken = false;
    }
}

class Library
{
    static void Main()
    {
        Book[] library = new Book[]
        {
            new Book("Мастер и Маргарита", 1967),
            new Book("Война и мир", 1869),
            new Book("Три мушкетера", 1844),
            new Book("Питер Пэн", 1911),
            new Book("Гарри Поттер и тайная комната", 1998),
        };

        DisplayBooks(library);

        CheckOutBook(library, "Три мушкетера");
        CheckOutBook(library, "Гарри Поттер и тайная комната");

        DisplayBooks(library);

        ReturnBook(library, "Три мушкетера");
        ReturnBook(library, "Мастер и Маргарита");

        DisplayBooks(library);

        CountRecentBooks(library);
    }

    static void DisplayBooks(Book[] library)
    {
        Console.WriteLine("Текущие книги в библиотеке:");
        foreach (var book in library)
        {
            string status = book.Taken ? "На руках" : "В наличии";
            Console.WriteLine($"{book.Name} ({book.ReleaseYear}) - {status}");
        }
        Console.WriteLine();
    }

    static void CheckOutBook(Book[] library, string name)
    {
        foreach (var book in library)
        {
            if (book.Name == name)
            {
                if (!book.Taken)
                {
                    book.Taken = true;
                    Console.WriteLine($"Книга '{name}' была взята.");
                }
                else
                {
                    Console.WriteLine($"Книга '{name}' уже взята.");
                }
                return;
            }
        }
        Console.WriteLine($"Книга '{name}' не найдена в библиотеке.");
    }

    static void ReturnBook(Book[] library, string name)
    {
        foreach (var book in library)
        {
            if (book.Name == name)
            {
                if (book.Taken)
                {
                    book.Taken = false;
                    Console.WriteLine($"Книга '{name}' успешно возвращена.");
                }
                else
                {
                    Console.WriteLine($"Книга '{name}' не была взята.");
                }
                return;
            }
        }
        Console.WriteLine($"Книга '{name}' не найдена в библиотеке.");
    }

    static void CountRecentBooks(Book[] library)
    {
        int count = 0;
        foreach (var book in library)
        {
            if (book.ReleaseYear > 2000)
            {
                count++;
            }
        }
        Console.WriteLine($"Книг, изданных после 2000 года: {count}");
    }
}
