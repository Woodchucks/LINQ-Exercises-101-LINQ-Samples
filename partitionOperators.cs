//select only the first 3 elements of the array
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var first3 = numbers.Take(3);
Console.WriteLine("First 3 elem of array:");

foreach(var nr in first3)
{
    Console.WriteLine(nr);
}

//select the first 3 orders from customers in Washington
List<Customer> customers = GetCustomerList();

var ordersFirst3 = (from cust in customers
                   from order in cust.Orders
                   where cust.Region == "WA"
                   select (cust.CompanyName, order.OrderID)).Take(3);

foreach(var order in ordersFirst3)
{
    Console.WriteLine(order);
}

//select all but the first 4 elements of the array
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var getAllButFirst4Digits = numbers.Skip(4);

Console.WriteLine("All but first 4 numbers:");
foreach (var nr in getAllButFirst4Digits)
{
    Console.WriteLine(nr);
}

//select all but the first 2 orders from customers in Washington
List<Customer> customers = GetCustomerList();

var orders = (from cust in customers
             from order in cust.Orders
             where cust.Region == "WA"
             select (cust.CompanyName, order.OrderID)).Skip(2);
             
Console.WriteLine("All but the first 2 orders from customers in Washington");
foreach(var order in orders)
{
  Console.WriteLine($"Name: {order.CompanyName}, order id: {order.OrderID}");
}

//select elements starting from the beginning of the array until a number is hit that is not less than 6
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var firstNrsLessThan6 = numbers.TakeWhile(nr => nr < 6);
Console.WriteLine("Elements starting from the beginning of the array until a number is hit that is not less than 6:");
foreach(var nr in firstNrsLessThan6)
{
  Console.WriteLine(nr);
}

//select elements starting from the beginning of the array until a number is hit that is less than its position in the array
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var displayUntilNrValueLessThanPosition = numbers.TakeWhile((nr, index) => nr >= index);
foreach(var nr in displayUntilNrValueLessThanPosition)
{
  Console.WriteLine(nr);
}

//select elements of the array starting from the first element divisible by 3
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var numStartingFromDigitDivBy3 = numbers.SkipWhile(nr => nr%3 != 0);
foreach(var nr in numStartingFromDigitDivBy3)
{
  Console.WriteLine(nr);
}

//Select elements of the array starting from the first element less than its position
int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
var firstDigitOfValueLessThanItsIndex = numbers.SkipWhile((nr, index) => nr >= index);
foreach(var nr in firstDigitOfValueLessThanItsIndex)
{
  Console.WriteLine(nr);
}
