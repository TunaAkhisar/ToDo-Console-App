namespace ToDo
{
    public class DeleteCard : AllOperations{
        public override void DeletingOperation()
        {
            bool control = true;
            while (control){
                
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. "+
                "Lütfen kart başlığını yazınız:  ");
                string cardTitle = Console.ReadLine();

                var item = ExistCards.cardsList.FindAll((x) => x.Title == cardTitle);

                foreach (var i in item)
                {
                    ExistCards.cardsList.Remove(i);
                    Console.WriteLine(i.Title + " Silindi");
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