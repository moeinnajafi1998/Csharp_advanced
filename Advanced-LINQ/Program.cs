// 1. Grouping and Aggregating Data

// Grouping: Grouping in LINQ allows you to categorize data into groups based on a specified key. 
// The group by clause is used to create groups, and it can be combined with other LINQ operators to perform operations on each group.

public class Product{
    public string? Name{ get; set; }
    public string? Category { get; set; }
    public double? Price { get; set; }
}

class Program{
    static void Main(){
        var products = new List<Product>
        {
            new Product { Name = "Apple", Category = "Fruit", Price = 1.2 },
            new Product { Name = "Banana", Category = "Fruit", Price = 0.8 },
            new Product { Name = "Carrot", Category = "Vegetable", Price = 0.5 },
            new Product { Name = "Broccoli", Category = "Vegetable", Price = 1.1 }
        };

        var groupedProducts = from p in products
                            group p by p.Category into g
                            select new
                            {
                                Category = g.Key,
                                Products = g.ToList()
                            };

        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Category}");
            foreach (var product in group.Products)
            {
                Console.WriteLine($" - {product.Name}");
            }
        }

        // In this example, products are grouped by their Category, and each group contains a list of products in that category.

        // Aggregating: Aggregation functions like Count, Sum, Average, Min, and Max can be applied to groups to perform calculations.
        var categoryTotals = from p in products
                            group p by p.Category into g
                            select new
                            {
                                Category = g.Key,
                                TotalPrice = g.Sum(x => x.Price)
                            };

        foreach (var group in categoryTotals)
        {
            Console.WriteLine($"Category: {group.Category}, Total Price: {group.TotalPrice}");
        }
        // This example calculates the total price of products in each category.



    }
}