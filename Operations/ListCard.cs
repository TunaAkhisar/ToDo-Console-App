namespace ToDo
{
    public class ListCard : AllOperations
    {
        public override void ListingOperation()
        {
            bool control = true;
            while (control)
            {
                List<Card> doneLine = new List<Card>();
                List<Card> todoLine = new List<Card>();
                List<Card> progLine = new List<Card>();

                foreach (Card item in (ExistCards.cardsList))
                {
                    if (item.Line == "TODO")
                    {
                        todoLine.Add(item);
                    }
                    else if (item.Line == "DONE")
                    {
                        doneLine.Add(item);
                    }
                    else if (item.Line == "INPROGRESS")
                    {
                        progLine.Add(item);
                    }
                }

                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");

                foreach (var item in todoLine)
                {
                    Console.WriteLine("Başlık           :" + item.Title);
                    Console.WriteLine("İçerik           :" + item.Content);
                    Console.WriteLine("Atanan Kişi      :" + item.TeamMember);
                    Console.WriteLine("Büyüklük         :" + item.Size);
                    Console.WriteLine("************************");
                }

                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");

                foreach (var item in progLine)
                {
                    Console.WriteLine("Başlık           :" + item.Title);
                    Console.WriteLine("İçerik           :" + item.Content);
                    Console.WriteLine("Atanan Kişi      :" + item.TeamMember);
                    Console.WriteLine("Büyüklük         :" + item.Size);
                    Console.WriteLine("************************");
                }


                Console.WriteLine("Done Line");
                Console.WriteLine("************************");

                foreach (var item in doneLine)
                {
                    Console.WriteLine("Başlık           :" + item.Title);
                    Console.WriteLine("İçerik           :" + item.Content);
                    Console.WriteLine("Atanan Kişi      :" + item.TeamMember);
                    Console.WriteLine("Büyüklük         :" + item.Size);
                    Console.WriteLine("************************");
                }

                Console.WriteLine("* Ana Sayfaya dönmek için  : (1)");
                Console.WriteLine("* Tekrar işlem yapmak için : (2)");
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    control = false;
                    break;
                }
                else if (choose == "2")
                {
                    continue;
                }
                
            }
        }
    }
}