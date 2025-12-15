using SmartFridge;


namespace SmartFridge
{
    public class SmartFridgeService
    {
        static void Main(string[] args)
        {
            var product1 = new Product("Молоко", new DateTime(2025, 12, 31));
            var fridge = new SmartFridge();

            fridge.AddProduct(product1);
            Console.WriteLine($"Додали {product1.Name} до холодильнику");

            var product2 = new Product("Яйця", new DateTime(2025, 12, 01));

            fridge.AddProduct(product2);
            Console.WriteLine($"Додали {product2.Name} до холодильнику");

            var allProducts = fridge.GetAllProducts();
            Console.WriteLine("Всi продукти:");
            foreach (var p in allProducts)
            {
                Console.WriteLine($"{p.Name} - термiн придатностi: {p.ExpirationDate.ToShortDateString()}");
            }
            Console.WriteLine("Всi простроченi продукти:");
            var allExpiredProducts = fridge.GetExpiredProducts();

            foreach (var p in allExpiredProducts)
            {
                Console.WriteLine($"{p.Name} - термiн придатностi: {p.ExpirationDate.ToShortDateString()}");
            }
            fridge.RemoveProduct("Яйця");
            Console.WriteLine($"Прибрали {product2.Name}");
        }
    }
}