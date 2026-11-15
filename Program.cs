using BookBase;
internal class Program
{
    private static void Main(string[] args)
    {
        //Book book = new Book();
        //book.title = "The Great Gatsby";
        //book.pages = 180;
        //object obj = book;
        //Console.WriteLine(obj);
        //.........................//

        //Console.WriteLine(book.ToString());
        //Console.WriteLine(book.Equals(book));
        //Console.WriteLine(book.GetHashCode());
        //Console.WriteLine(book.GetType());
        //.........................//

        // int pages = "464"; Compile time error
        // int pages = 464; // This is correct
        //.........................//

        //try
        //{
        //    int x = 10;
        //    int y = 0;
        //    int Result = x / y;
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Cannot divide by zero:");
        //}
        //finally
        //{
        //    Console.WriteLine("Done");
        //}
        //.........................//

        //int pages = 300;
        //double pagesInDouble = pages;
        //Console.WriteLine(pagesInDouble);
        //.........................//

        //double price = 49.99;
        //int priceInInt = (int)price;
        //Console.WriteLine(priceInInt);
        //.........................//

        //string pagesText = "464";
        //int pages = Convert.ToInt32(pagesText);
        //Console.WriteLine(pages);
        //.........................//

        //string yearText = "2023";
        //int year = int.Parse(yearText);
        //Console.WriteLine(year);
        //string badText = "abc";
        //try
        //{
        //    int badNumber = int.Parse(badText);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Invalid number ");
        //}
        //.........................//

        //int pages = 464;
        //string pagesText = pages.ToString();
        //Console.WriteLine(pagesText.GetType());
        //.........................//

        // Boxing
        int copies = 100;
        object obj = copies;
        Console.WriteLine(obj);
        // Unboxing
        int newCopies = (int)obj;
        Console.WriteLine(newCopies);
        //.........................//
    }
}