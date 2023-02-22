namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        mainMenu:
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşimak");
            Console.WriteLine("(0) Çikiş");

            string choosed = Console.ReadLine();

            ExistCards existCards = new ExistCards();

            bool control = true;

            while (control)
            {
                if (choosed == "1")
                {
                    Console.WriteLine("Kart Listele  !!!!");

                    ListCard listCard = new ListCard();
                    listCard.ListingOperation();
                    goto mainMenu;
                }
                else if (choosed == "2")
                {
                    Console.WriteLine("Kart Ekle  !!!!");

                    AddCard addCard = new AddCard();
                    addCard.AddingOperation();
                    goto mainMenu;



                }
                else if (choosed == "3")
                {
                    Console.WriteLine("Kart Sil  !!!!");

                    DeleteCard deleteCard = new DeleteCard();
                    deleteCard.DeletingOperation();
                    goto mainMenu;

                }
                else if (choosed == "4")
                {
                    Console.WriteLine("Kart Tasi  !!!!");

                    MoveCard moveCard = new MoveCard();
                    moveCard.MovingOperation();
                    goto mainMenu;
                }
                else if (choosed == "0")
                {
                    control = false;
                }
                else
                {
                    Console.WriteLine("Yanlis deger");
                    goto mainMenu;
                }
            }


        }
    }
}