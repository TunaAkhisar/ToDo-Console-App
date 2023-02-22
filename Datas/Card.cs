namespace ToDo
{
    public class Card
    {
        private string title;
        private string content;
        private string teamMember;
        private string size;
        private string line;

        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string TeamMember { get => teamMember; set => teamMember = value; }
        public string Size { get => size; set => size = value; }
        public string Line { get => line; set => line = value; }


        public Card(string _title, string _content, string _teamMember, string _size, string _line)
        {
            Title = _title;
            Content = _content;
            TeamMember = _teamMember;
            Size = _size;
            Line = _line;
        }

        public Card()
        {
        }
    }
}