namespace ToDo
{
    public class AddCard : AllOperations
    {
        public override void AddingOperation()
        {
            bool control = true;
            while (control)
            {
                Console.WriteLine("Baslik Giriniz : ");
                string title = Console.ReadLine();

                Console.WriteLine("İcerik Giriniz : ");
                string content = Console.ReadLine();

                Console.WriteLine("Büyüklük Seçiniz -> XS,S,M,L,XL");
                string size = Console.ReadLine();

                Console.WriteLine("Kisi Giriniz : ");
                string person = Console.ReadLine();

                Console.WriteLine("Boad Seciniz : (TODO)-(DONE)-(INPROGRESS)");
                string board = Console.ReadLine();

                ExistCards existCards = new ExistCards();

                var item = ExistCards.personList.Find((x) => x.Name == person);


                if (item != null)
                {
                    Console.WriteLine(item.Name + "Ekleme Yapildi!!!");
                    ExistCards.cardsList.Add(new Card(title, content, person, size, board));
                }
                else
                {
                    Console.WriteLine("Hatali");
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