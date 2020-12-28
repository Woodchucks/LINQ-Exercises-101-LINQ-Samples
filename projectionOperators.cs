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

