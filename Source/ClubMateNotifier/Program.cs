namespace ClubMateNotifier;

static class Program
{
    private static readonly HttpClient Client = new HttpClient();

    static async Task<int> Main(string[] args)
    {
        var targetProductId = args.FirstOrDefault();
        string pushbulletToken;
        if (string.IsNullOrEmpty(targetProductId))
        {
            Console.WriteLine("Please add a product ID as a program argument.");
            return 1;
        }

        try
        {
            pushbulletToken = args[1];
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("No Pushbullet token supplied.");
            return 1;
        }
        
        var storeChecker = new ClubMateStoreChecker(Client);
        var pushbullet = new Pushbullet(Client, pushbulletToken);
        bool targetProductIsInStock = false;
        // 12 hours
        var sleepTime = 12 * 3600 * 1000;

        await pushbullet.NotifyUser("Pushbullet integration works!");
        Console.WriteLine($"Looking for product ID: {targetProductId}");

        while (!targetProductIsInStock)
        {
            var products = await storeChecker.GetAllProducts();
            if (products == null)
            {
                Console.WriteLine("Unable to fetch products from club-mate.uk!");
                await pushbullet.NotifyUser("Unable to fetch products from club-mate.uk!");
                return 1;
            }
            
            var targetProduct = products.Data.FirstOrDefault(p => p.Id == targetProductId);
            if (targetProduct == null)
            {
                Console.WriteLine($"{DateTime.Now:O} Item does not exist or it has been removed from the store.");
                Thread.Sleep(sleepTime);
            }

            if (targetProduct.Inventory.Total > 0)
            {
                await pushbullet.NotifyUser($"{targetProduct.Name} is in stock - {targetProduct.Inventory.Total} items available!");
                targetProductIsInStock = true;
            }
            else
            {
                Console.WriteLine($"{DateTime.Now:O} {targetProduct.Name} is not in stock at the moment.");
                Thread.Sleep(sleepTime);
            }    
        }

        return 0;
    }
}