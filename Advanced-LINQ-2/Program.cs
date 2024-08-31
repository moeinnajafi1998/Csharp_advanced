// 2. Joining Multiple Data Sources
// LINQ supports various types of joins, allowing you to combine data from multiple sources. 
// The most common are join (equivalent to SQL inner join) and group join (similar to SQL left join).

// Inner Join Example:

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }  // Foreign key to Customer
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime OrderDate { get; set; }
}


class Program{
    public static void Main(){
        var customers = new List<Customer>
    {
        new Customer { Id = 1, Name = "John" },
        new Customer { Id = 2, Name = "Jane" }
    };

    var orders = new List<Order>
    {
        new Order { Id = 1, CustomerId = 1, ProductName = "Apple" },
        new Order { Id = 2, CustomerId = 2, ProductName = "Banana" },
        new Order { Id = 3, CustomerId = 1, ProductName = "Carrot" }
    };

    var customerOrders = from c in customers
                        join o in orders on c.Id equals o.CustomerId
                        select new
                        {
                            CustomerName = c.Name,
                            o.ProductName
                        };

    foreach (var co in customerOrders)
    {
        Console.WriteLine($"{co.CustomerName} ordered {co.ProductName}");
    }
    // Here, we join the customers and orders lists on the CustomerId, returning a collection of customer names and their respective orders.

    // Group Join Example:
    var customerGroupOrders = from c in customers
                          join o in orders on c.Id equals o.CustomerId into customerGroup
                          select new
                          {
                              CustomerName = c.Name,
                              Orders = customerGroup.ToList()
                          };

    foreach (var customer in customerGroupOrders)
    {
        Console.WriteLine($"{customer.CustomerName}'s Orders:");
        foreach (var order in customer.Orders)
        {
            Console.WriteLine($" - {order.ProductName}");
        }
    }

    }
}