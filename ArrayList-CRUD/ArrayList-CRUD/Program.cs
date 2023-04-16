namespace ArrayList_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********ArrayList CRUD operations in C#**********");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("*****Creating & Adding elements in ArrayList*****");
            Console.WriteLine("----------------------------------------------------");

            //Adding elements to ArrayList using Add() method
            Console.WriteLine("Elements in ArrayList-1: ");
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(1); //Adding Integer Value
            arrayList1.Add('D'); //Adding Char Value
            arrayList1.Add("Meghana"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(5.25); //Adding double
            arrayList1.Add(null); //Adding null
            foreach (var item in arrayList1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            //Adding Elements to ArrayList using object initializer 
            Console.WriteLine("Elements in ArrayList-2: ");
            var arrayList2 = new ArrayList()
            {
                2, 'A', "Priyanka", false, 15.6
            };
            foreach (var item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("*****Access elements in ArrayList*****");
            Console.WriteLine("-------------------------------------------");
            //Accessing individual elements from ArrayList using Indexer
            int firstElement = (int)arrayList1[0];
            char secondElement = (char)arrayList1[1];
            //int secondElement = (int) arrayList1[1]; //Error: cannot cover Char to int
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");

            //Using var keyword without explicit casting
            var firsItem = arrayList1[0];
            var secondItem = arrayList1[1];
            //var fifthElement = arrayList1[10]; //Error: Index out of range
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");
            Console.WriteLine("\n");

            Console.WriteLine("*****Insert elements in ArrayList*****");
            Console.WriteLine("------------------------------------------");
            //Insert "First Element" at First Position i.e. Index 0
            arrayList2.Insert(0, "Akula");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList2.Insert(2, "Pinky");
            //Iterating through foreach loop
            foreach (var item in arrayList2)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\n");

            Console.WriteLine("*****Update elements in ArrayList*****");
            Console.WriteLine("------------------------------------------");
            //update elements
            arrayList1[0] = 10;
            arrayList1[1] = "Dasari";
            //arrayList1[10] = 500; //Error: Index out of range
            foreach (var item in arrayList1)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("*****Remove (or) Delete elements in ArrayList*****");
            Console.WriteLine("----------------------------------------------------");
            arrayList1.Remove(null); //Removes occurance of null in List-1
            Console.WriteLine("\nArrayList1 Elements After CRUD operations : ");
            foreach (var item in arrayList1)
            {
                Console.WriteLine($"{item}");
            }
            arrayList2.RemoveAt(1); //Removes element at index postion 1, it is 0 based index in List-2
            arrayList2.RemoveAt(2); //Removes element at index postion 2, it is 0 based index in List-2
            Console.WriteLine("\nArrayList2 Elements After CRUD operations : ");
            foreach (var item in arrayList2)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}