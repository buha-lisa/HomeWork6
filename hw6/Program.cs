namespace hw6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        {
                            Magazine magazine = new Magazine()
                            {
                                EmployeeAmount = 13
                            };
                            Magazine magazine2 = magazine + 3;
                            Console.WriteLine($"{magazine2.Name} - {magazine2.EmployeeAmount}");

                            Magazine magazine3 = magazine - 3;
                            Console.WriteLine($"{magazine3.Name} - {magazine3.EmployeeAmount}");

                            Magazine magazine4 = new Magazine()
                            {
                                EmployeeAmount = 16
                            };
                            if (magazine == magazine4)
                            {
                                Console.WriteLine("==");
                            }
                            if (magazine != magazine4)
                            {
                                Console.WriteLine("!=");
                            }
                            if (magazine > magazine4)
                            {
                                Console.WriteLine(">");
                            }
                            if (magazine < magazine4)
                            {
                                Console.WriteLine("<");
                            }
                            if (magazine.Equals(magazine4))
                            {
                                Console.WriteLine("==");
                            }
                            break;
                        }
                    case 2:
                        {
                            Shop shop = new Shop()
                            {
                                Square = 13
                            };
                            Shop shop2 = shop + 3.4;
                            Console.WriteLine($"{shop2.Name} - {shop2.Square}");

                            Shop shop3 = shop - 6.8;
                            Console.WriteLine($"{shop3.Name} - {shop3.Square}");

                            Shop shop4 = new Shop()
                            {
                                Square = 16
                            };
                            if (shop == shop4)
                            {
                                Console.WriteLine("==");
                            }
                            if (shop != shop4)
                            {
                                Console.WriteLine("!=");
                            }
                            if (shop > shop4)
                            {
                                Console.WriteLine(">");
                            }
                            if (shop < shop4)
                            {
                                Console.WriteLine("<");
                            }
                            if (shop.Equals(shop4))
                            {
                                Console.WriteLine("==");
                            }
                            break;
                        }
                    case 3:
                        {
                            BookList book = new BookList(5);
                            book = book + "Dune";
                            book = book + "Maze runner";
                            book.ShowBook();

                            book = book - "Dune";
                            book.ShowBook();

                            BookList book2 = new BookList(5);
                            book2 = book2 + "Dune";
                            if (book2 == book)
                            {
                                Console.WriteLine("==");
                            }
                            if (book2 != book)
                            {
                                Console.WriteLine("!=");
                            }
                            break;
                        }
                }
                if (task == 0) break;
            }
        }
    }
}
