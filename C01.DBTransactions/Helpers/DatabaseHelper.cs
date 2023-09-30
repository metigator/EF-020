using C01.DBTransactions.Data;
using C01.DBTransactions.Entities;

namespace C01.DBTransactions.Helpers
{
    public static class DatabaseHelper
    {
        public static void RecreateCleanDatabase()
        {
            using var context = new AppDbContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static void PopulateDatabase()
        {
            using (var context = new AppDbContext())
            {
                context.Add(
                    new Account
                    {
                        AccountNumber = "0001_111111111_1111",
                        AccountHolder = "Ahmed Ali",
                        Balance = 10000m
                    });

                context.Add(
                    new Account
                    {
                        AccountNumber = "0001_111111111_2222",
                        AccountHolder = "Reem Ali",
                        Balance = 15000
                    });

                context.SaveChanges();
            }
        }
    }
}
