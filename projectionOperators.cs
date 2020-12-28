//Create digits plus 1 in array
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var nrPlusOne = from nr in numbers
                select nr + 1;

Console.WriteLine("Numbers plus 1: ");
foreach(var nr in nrPlusOne)
{
    Console.WriteLine(nr);
}
return 0; //without - not all code path returns an output

//select a sequence of just the names of a list of products
List<Product> products = GetProductList();

var productNames = from prod in products
                    select prod.ProductName;

Console.WriteLine("Product names in List:");
foreach(var product in productNames)
{
    Console.WriteLine(product);
}

//produce a sequence of strings representing the text version of a sequence of ints
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var intRepresentedByStrings = numbers.Select(nr => strings[nr]);
// var intRepresentedByStrings = from nr in numbers
//                                 select strings[nr];

foreach(var nr in intRepresentedByStrings)
{
    Console.WriteLine(nr);
}

//SELECT ANONYMOUS TYPES OR TUPLES

//Create uppercase and lowercase versions of each word in the original array
string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

var wordsCaseSensitive = from wrd in words
                         select new {upper = wrd.ToUpper(), lower = wrd.ToLower()};

foreach(var word in wordsCaseSensitive)
{
    Console.WriteLine($"Word in uppercase: {word.upper}, words in lowercase: {word.lower}");
}

//create a sequence containing text representations of digits and whether their length is even or odd
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var digitsEveOrOdd = from num in numbers
                        select new {Digit = strings[num], Even = (num%2 == 0)};

foreach(var nr in digitsEveOrOdd)
{
    Console.WriteLine($"{nr.Digit} is a {(nr.Even ? "is even" : "is odd")}");
}

//determine if the value of ints in an array match their position in the array
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var matchingPositions = numbers.Select((nr, index) => (Digit: nr, Match: (nr == index)));
foreach(var mp in matchingPositions)
{
  Console.WriteLine($"{mp.Digit} is matching: {mp.Match}");
}
//a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type
List<Product> products = GetProductList();

var productDetails = from prod in products
                     select (prod.ProductName, prod.Category, Price: prod.UnitPrice);

Console.WriteLine("Product details:");
foreach(var pr in productDetails)
{
    Console.WriteLine($"Name: {pr.ProductName}, Category: {pr.Category}, Price: {pr.Price}");
}

//return all pairs of numbers from both arrays that the number from numbersA is less than the number from numbersB
int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };

var nrIsLess = from nrA in numbersA
               from nrB in numbersB
               where nrA < nrB
               select (nrA, nrB);

foreach(var nr in nrIsLess)
{
    Console.WriteLine($"{nr.nrA} is less than {nr.nrB}");
}

//select all orders where the order was made in 1998 or later
List<Customer> customers = GetCustomerList();

var orders = from cust in customers
             from ord in cust.Orders
             where ord.OrderDate >= new DateTime(1998, 1, 1)
             select (cust.CustomerID, ord.OrderID, ord.OrderDate);

Console.WriteLine("Orders made in 1998 or later: ");
foreach(var order in orders)
{
    Console.WriteLine($"{order.CustomerID}, {order.OrderID}, {order.OrderDate}");
}

// select all orders where the order total is greater than 2000.00
List<Customer> customers = GetCustomerList();

var orders = from cust in customers
             from order in cust.Orders
             where order.Total > 2000.00M
             select (cust.CustomerID, order.Total);

foreach(var order in orders)
{
    Console.WriteLine($"Customer {order.CustomerID} has a total order of: {order.Total}");
}

//
