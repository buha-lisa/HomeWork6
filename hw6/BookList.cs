namespace hw6
{
    class BookList
    {
        public string[] Books;
        public int Count;

        public BookList(int capacity)
        {
            Books = new string[capacity];
            Count = 0;
        }
        public void ShowBook()
        {
            for (int i = 0; i < Count; i++)
                Console.WriteLine(Books[i]);
        }

        public void AddBook(string book)
        {
            if (Count < Books.Length)
            {
                Books[Count] = book;
                Count++;
            }
            else
            {
                Console.WriteLine("Reading list is full.");
            }
        }

        public bool RemoveBook(string book)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Books[i] == book)
                {
                    for (int j = i; j < Count - 1; j++)
                    {
                        Books[j] = Books[j + 1];
                    }
                    Count--;
                    return true;
                }
            }
            return false;
        }

        public bool ContainsBook(string book)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Books[i] == book)
                {
                    return true;
                }
            }
            return false;
        }

        public static BookList operator +(BookList readingList, string book)
        {
            readingList.AddBook(book);
            return readingList;
        }

        public static BookList operator -(BookList readingList, string book)
        {
            readingList.RemoveBook(book);
            return readingList;
        }

        public static BookList operator ==(BookList readingList, string book)
        {
            readingList.ContainsBook(book);
            return readingList;
        }
        public static BookList operator !=(BookList readingList, string book)
        {
            readingList.ContainsBook(book);
            return readingList;
        }

    }
}
