namespace ToDo
{
    public class MoveCard : AllOperations
    {
        public override void MovingOperation()
        {
            bool control = true;
            while (control)
            {
                Console.WriteLine("Lütfen kart başlığını yazınız:  ");
                string cardTitle = Console.ReadLine();

                var item = ExistCards.cardsList.Find((x) => x.Title == cardTitle);

                if (item != null)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************\n");

                    Console.WriteLine("Başlık           : " + item.Title);
                    Console.WriteLine("İçerik           : " + item.Content);
                    Console.WriteLine("Atanan Kişi      : " + item.TeamMember);
                    Console.WriteLine("Büyüklük         : " + item.Size);
                    Console.WriteLine("Line             : " + item.Line);

                    Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: " +
                                    "\n(1) TODO" +
                                    "\n(2) IN PROGRESS" +
                                    "\n(3) DONE");

                    string check = Console.ReadLine();

                    if (check == "1")
                    {
                        item.Line = "TODO";
                        break;
                    }
                    else if (check == "2")
                    {
                        item.Line = "INPROGRESS";
                        break;
                    }
                    else if (check == "3")
                    {
                        item.Line = "DONE";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı." +
                                        "Lütfen bir seçim yapınız.");

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
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı." +
                                    "Lütfen bir seçim yapınız.");

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
}