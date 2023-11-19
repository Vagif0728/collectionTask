namespace TaskCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> programmingLanguages = new Dictionary<string, int>
        {
            {"C", 1972},
            {"Java", 1995},
            {"Python", 1991},
            {"JavaScript", 1995},
            {"Ruby", 1995},
            {"Swift", 2014},
            {"Go", 2009},
            {"C#", 2000},
            {"PHP", 1995}
        };

        
        var sortOfLanguages = programmingLanguages.OrderBy(lang => lang.Value);

        
        foreach (var lang in sortOfLanguages)
        {
            Console.WriteLine($"{lang.Key}: {lang.Value}");
        }
        }
    }
}