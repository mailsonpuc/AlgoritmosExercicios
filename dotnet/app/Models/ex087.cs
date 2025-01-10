
namespace app.Models
{
    public class ex087
    {
        public void Test()
        {
            var contacts = new[]
    {
            new
    {
        Name = "Eugene Zabokritski",
        PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
    },
            new
    {
        Name = "Hanying Feng",
        PhoneNumbers = new[] { "650-555-0199" }
    }
};

            foreach (var item in contacts)
            {
                Console.WriteLine(item);
            }
        }
    }
}