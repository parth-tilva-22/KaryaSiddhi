//namespace KaryaSiddhi.Data
//{
//    public class Extension
//    {
//        public static void CreateDbIfNotExists(this IHost host)
//        {
//            {
//                using (var scope = host.Services.CreateScope())
//                {
//                    var services = scope.ServiceProvider;
//                    var context = services.GetRequiredService<KaryaSiddhiDbContext>();
//                    if (context.Database.EnsureCreated())
//                    {
//                        DbInitializer.Initialize(context);
//                    }
//                }
//            }
//        }
//    }
//}


//namespace ContosoPizza.Data;

//public static class Extensions
//{
//    public static void CreateDbIfNotExists(this IHost host)
//    {
//        {
//            using (var scope = host.Services.CreateScope())
//            {
//                var services = scope.ServiceProvider;
//                var context = services.GetRequiredService<PizzaContext>();
//                if (context.Database.EnsureCreated())
//                {
//                    DbInitializer.Initialize(context);
//                }
//            }
//        }
//    }
//}