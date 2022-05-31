using samuraiApp.Domain;
using SamuraiApp.Data;

namespace SamuraiApp.UI
{
    class Program
    {
        private static SamuraiContext _context;

        static void Main(string[] args)
        {
            try
            {
                _context = new SamuraiContext();
                Console.WriteLine("Projecto iniciado");
                _context.Database.EnsureCreated();
                GetSamurais("Before Add");

                AddSamurai();

                GetSamurais("After Add:");
                Console.Write("Press any key to continue");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddSamurai()
        {
            Samurai jack = new Samurai("Samurai Jack");
            _context.Samurais.Add(jack);
            _context.SaveChanges();

            //Quote jackQuote = new Quote (jack, "Hola jackarola") { Id = jack.Id};
            //jack.Quotes.Add(jackQuote);
            //_context.Quotes.Add(jackQuote);
            //_context.SaveChanges();
        }

        private static void GetSamurais(string? value)
        {
            var samurais = _context.Samurais.ToList();
            Console.WriteLine("------  Listado samurais: ------");

            foreach (var item in samurais)
            {
                Console.WriteLine($"Samurai: { item.Name}");
            }
        }

    }
}
