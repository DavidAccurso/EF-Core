namespace samuraiApp.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();

        public Samurai(string name)
        {
            this.Name = name;
        }
    }
}