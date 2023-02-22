namespace ToDo
{
    public class ExistCards
    {
        public static List<Person> personList = new List<Person>();
        public static List<Card> cardsList = new List<Card>();

        static ExistCards()
        {
            personList.Add(new Person("1", "Ayse"));
            personList.Add(new Person("2", "Fatma"));
            personList.Add(new Person("3", "Ahmet"));
            personList.Add(new Person("4", "Mehmet"));

            cardsList.Add(new Card("Ders", "Yazilim", "Ayse", "S", "DONE"));
            cardsList.Add(new Card("Oku", "Kitap", "Ayse", "S", "INPROGRESS"));
            cardsList.Add(new Card("Kurs", "Tenis", "Ayse", "M", "TODO"));
            cardsList.Add(new Card("Ders", "Mat", "Mehmet", "L", "TODO"));
        }
    }
}