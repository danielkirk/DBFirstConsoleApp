using System.Linq;

namespace DBFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SocialMediaEntities())
            {
                var u = context.Users.First(i => i.Id == 3);
                u.FirstName = "Steph";
                u.LastName = "Kirky";
                context.SaveChanges();
            }
        }
    }
}
