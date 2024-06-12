using Productify.Domain;
using Productify.Domain.Entities;
using Productify.Domain.Services;

ProductService productService = new ProductService();
Product stokProduct = null;

while(true)
{
    if (stokProduct == null)
    {
        Console.WriteLine($"Ürün stok güncelleme.");
        Console.WriteLine($"---------------------------");
        Console.WriteLine($"Yapmak istediğiniz işlemi giriniz.");
        Console.WriteLine($"1- Ürün girişi:");
        Console.WriteLine($"2- Stok görüntüleme:");
        Console.WriteLine($"3- Ürün silme:");
        string secim = Console.ReadLine();

        if( secim=="1")
        {
           
            {
                Console.WriteLine($"Ürün adı giriniz.");
                string name = Console.ReadLine();

                Console.WriteLine($"Ürün açıklamasını giriniz.");
                string description = Console.ReadLine();

                Console.WriteLine($"Ürün fiyatı giriniz.");
                decimal price = decimal.Parse( Console.ReadLine());

                Console.WriteLine($"Ürün stoğunu giriniz.");
                int stock = Convert.ToInt32( Console.ReadLine());

                productService.Add(name,description,price,stock);
            }
        }
        else if (secim=="2")
        {
            var products = productService.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine($"ürün adı:{product.Name}-ürün fiyatı:{product.Price}TL");
            }
        }
        else if (secim=="3") 
        {
            Console.WriteLine($"Silmek istediğiniz ürünün Id numarasını giriniz.");
            string id = Console.ReadLine();
            productService.Delete(id);
            Console.WriteLine($"Silmek istediğiniz ürün stoktan başarıyla silindi.");

        }
    }
}








