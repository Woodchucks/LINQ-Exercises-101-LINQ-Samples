//find all elements of an array less than 5
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var lessThanFive = from nr in numbers
                    where nr < 5
                    select nr;

Console.WriteLine("Nr less than 5:");
foreach(var nr in lessThanFive)
{
    Console.WriteLine(nr);
}

//find all products that are out of stock
List<Product> products = GetProductList();

var prodOutOfSTock = from prod in products
                        where prod.UnitsInStock == 0
                        select prod;
Console.WriteLine("Products out of stock:");
foreach(var product in prodOutOfSTock)
{
    Console.WriteLine($"{product.ProductName}");
}

//find all products that are in stock and cost more than 3.00 per unit
List<Product> products = GetProductList();

var prodInStockPriceMoreThan3 = from prod in products
                                where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                                select prod;

Console.WriteLine("Products in stock that cost more than 3.00:");
foreach(var product in prodInStockPriceMoreThan3)
{
    Console.WriteLine($"{product.ProductName}");
}

//find all customers in Washington and then use the resulting sequence to drill down into their orders
List<Customer> customers = GetCustomerList();

var customersFromWashington = from cust in customers
                                where cust.Region == "WA"
                                select cust;

Console.WriteLine("Customers from Washington and their orders:");
foreach(var customer in customersFromWashington)
{
    foreach(var order in customer.Orders)
    {
        Console.WriteLine($"{customer.CompanyName}: order nr: {order.OrderID}, transaction date: {order.OrderDate}");
    }
}


//find all digits which names are shorter than their values
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var digitNameShorterThanValue = digits.Where((digit, index) => digit.Length < index);
Console.WriteLine("Digits which names are shorter than its values:");
foreach(var dig in digitNameShorterThanValue)
{
    Console.WriteLine(dig);
}
