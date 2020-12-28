//sort a list of words by length
string[] words = { "cherry", "apple", "blueberry" };

var sortedWords = from wrd in words
                  orderby wrd.Length
                  select wrd;
foreach(var wrd in sortedWords)
{
  Console.WriteLine(wrd);
}

//sort a list of products by name
List<Product> products = GetProductList();
var prodSortedByName = from product in products
                       orderby product.ProductName
                       select product;
foreach(var prod in prodSortedByName)
{
  Console.WriteLine(prod);
}

//sort a list of products by units in stock from highest to lowest
List<Product> products = GetProductList();
var prodSortedByStock = from prod in products
                        orderby prod.UnitsInStock descending
                        select prod;

foreach (var pr in prodSortedByStock)
{
    Console.WriteLine(pr);
}

//create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
// var reverseWordsWithLetterIAtIndex1 = digits.Select(dig => dig[1] == 'i').Reverse();
// foreach (var digit in reverseWordsWithLetterIAtIndex1)
// {
//     Console.WriteLine(digit);
// }        true and false instead of values

var reverseWordsWithLetterIAtIndex1 = (
    from digit in digits
    where digit[1] == 'i'
    select digit)
    .Reverse();

Console.WriteLine("A backwards list of the digits with a second character of 'i':");
foreach (var wrd in reverseWordsWithLetterIAtIndex1)
{
    Console.WriteLine(wrd);
}
