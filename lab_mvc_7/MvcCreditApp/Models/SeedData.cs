using Microsoft.EntityFrameworkCore;

namespace MvcCreditApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CreditContext(serviceProvider.GetRequiredService<DbContextOptions<CreditContext>>()))
            {
                if (context == null || context.Credits == null)
                {
                    throw new ArgumentNullException("Null CreditContext");
                }
                if (context.Credits.Any())
                {
                    return;
                }
                context.Credits.Add(new Credit { Head = "Mortgage", Period = 10, Sum = 1000000, Procent = 15 });
                context.Credits.Add(new Credit { Head = "Educational", Period = 7, Sum = 300000, Procent = 10 });
                context.Credits.Add(new Credit { Head = "Consumer", Period = 5, Sum = 500000, Procent = 19 });
                context.Credits.AddRange(
                    new Credit
                    {
                        Head = "Preferential",
                        Period = 12,
                        Sum = 55555,
                        Procent = 7
                    },
                    new Credit
                    {
                        Head = "Urgent",
                        Period = 3,
                        Sum = 3333,
                        Procent = 19
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
