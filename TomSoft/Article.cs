namespace TomSoft
{
    class Article
    {
        public int id { get; }
        public string name { get; set; }

        public Article(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
