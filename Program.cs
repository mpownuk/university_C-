class Regal
    {
        public int Szerokość { get; set; }
        public int Wysokość { get; set; }
        public char Materiał { get; set; }

        public Regal(int szerokość, int wysokość, char materiał)
        {
            Szerokość = szerokość;
            Wysokość = wysokość;
            Materiał = materiał;
        }

        public void Rysuj()
        {
            for (int i = 0; i < Wysokość; i++)
            {
                for (int j = 0; j < Szerokość; j++)
                {
                    Console.Write(new string(Materiał, 6));
                }
                Console.Write(Materiał);
                Console.WriteLine("");

                for (int j = 0; j < Szerokość; j++)
                {
                    Console.Write(Materiał + "     ");
                }
                Console.Write(Materiał);
                Console.WriteLine("");
            }

            for (int i = 0; i < Szerokość; i++)
            {
                Console.Write(new string(Materiał, 6));
            }
            Console.Write(Materiał);
            Console.WriteLine();
        }
        public void WypiszInformacje()
        {
            Console.WriteLine($"Nazwa mebla: Regał");
            Console.WriteLine($"Szerokość: {Szerokość}");
            Console.WriteLine($"Wysokość: {Wysokość}");
            Console.WriteLine($"Materiał: {Materiał}");
        }

}

class Table
    {
        public int Szerokość { get; set; }
        public int Wysokość { get; set; }
        public char Materiał { get; set; }

        public Table(int szerokość, int wysokość, char materiał)
        {
            Szerokość = szerokość;
            Wysokość = wysokość;
            Materiał = materiał;
        }

        public void Rysuj()
        {
            for (int j = 0; j < Szerokość; j++)
                {
                    Console.Write(new string(Materiał, 2));
                }
        Console.Write(Materiał);
        for (int i = 0; i < Wysokość; i++)
            {
                Console.WriteLine("");

                for (int j = 0; j < Szerokość; j++)
                {
                if(j == 0)
                {
                    Console.Write(Materiał + " ");
                } else if( j > 0 && j < Szerokość)
                {
                    Console.Write("  ");
                } else
                {
                    Console.Write(Materiał);
                }
            }
                Console.Write(Materiał);
            }

        }
        public void WypiszInformacje()
        {
            Console.WriteLine($"Nazwa mebla: Stół");
            Console.WriteLine($"Szerokość: {Szerokość}");
            Console.WriteLine($"Wysokość: {Wysokość}");
            Console.WriteLine($"Materiał: {Materiał}");
        }
}

class Lamp
    {
        public int Szerokość { get; set; }
        public int Wysokość { get; set; }
        public char Materiał { get; set; }

        public Lamp(int szerokość, int wysokość, char materiał)
        {
            Szerokość = szerokość;
            Wysokość = wysokość;
            Materiał = materiał;
        }

        public void Rysuj()
        {
        bool isWidthEven = Szerokość % 2 == 0 ? true : false;
        int widthCount = Szerokość /2;
        for (int i = 0; i < Wysokość; i++)
                {
                    for ( int j= 0; j< Szerokość; j++)
                    {
                        Console.Write(Materiał);
                    }
                    Console.WriteLine();
                }
        for(int a=0; a< 4; a++)
        {
            for(int i = 0; i< Szerokość; i++)
            {
                if (isWidthEven)
                {
                    if ( widthCount != 1 && widthCount !=0)
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write("|");
                    }
                    widthCount--;
                } else
                {
                    if (widthCount != 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("|");
                    }
                    widthCount--;
                }
            }
            Console.WriteLine();
            widthCount = Szerokość / 2;
        }
    }
    public void WypiszInformacje()
    {
        Console.WriteLine($"Nazwa mebla: Lampa");
        Console.WriteLine($"Szerokość: {Szerokość}");
        Console.WriteLine($"Wysokość: {Wysokość}");
        Console.WriteLine($"Materiał: {Materiał}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        char wybor;
        do
        {
            Console.Write("Wybierz mebel do rysowania (Regał: R, Stół: S, Lampa: L): ");
            wybor = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (wybor != 'R' && wybor != 'S' && wybor != 'L');
        Console.WriteLine();

        Console.Write("Podaj szerokość mebla: ");
        int szerokość = PobierzWymiar();

        Console.Write("Podaj wysokość mebla: ");
        int wysokość = PobierzWymiar();

        Console.Write("Podaj materiał (pojedynczy znak): ");
        char materiał = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (wybor)
        {
            case 'R':
                Regal regał = new Regal(szerokość, wysokość, materiał);
                Console.WriteLine();
                regał.WypiszInformacje();
                Console.WriteLine();
                regał.Rysuj();
                Console.WriteLine();
                break;

            case 'S':
                Table stół = new Table(szerokość, wysokość, materiał);
                Console.WriteLine();
                stół.WypiszInformacje();
                Console.WriteLine();
                stół.Rysuj();
                Console.WriteLine();
                break;

            case 'L':
                Lamp lampa = new Lamp(szerokość, wysokość, materiał);
                Console.WriteLine();
                lampa.WypiszInformacje();
                Console.WriteLine();
                lampa.Rysuj();
                Console.WriteLine();
                break;

            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }
   static int PobierzWymiar()
    {
        int wymiar;
        bool poprawnyWymiar;

        do
        {
            Console.Write("Podaj wymiar (1-15): ");
            string input = Console.ReadLine();
            poprawnyWymiar = int.TryParse(input, out wymiar);

            if (!poprawnyWymiar)
            {
                Console.WriteLine("Błąd: Wprowadzono nieprawidłowe dane. Wprowadź tylko cyfry.");
            }
            else if (wymiar < 1 || wymiar > 15)
            {
                Console.WriteLine("Wymiar musi być pomiędzy 1 a 15. Spróbuj ponownie.");
                poprawnyWymiar = false;
            }
        } while (!poprawnyWymiar);

        return wymiar;
    }
}