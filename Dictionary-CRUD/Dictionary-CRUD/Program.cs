namespace Dictionary_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Dictionary CRUD operations in C#**********");
            Console.WriteLine("----------------------------------------------------");           

            Console.WriteLine("\n*****Creating & Adding elements in Dictionary*****");
            Console.WriteLine("----------------------------------------------------");

            Dictionary<string, int> VegPriceList = new Dictionary<string, int>();
            VegPriceList.Add("Tomato", 10);
            VegPriceList.Add("Potato", 15);
            VegPriceList.Add("Chilli", 20);
            VegPriceList.Add("Onion", 25);
            VegPriceList.Add("Carrot", 30);
            VegPriceList.Add("Cabbage", 35);

            Console.WriteLine("\n*****Retrieve/Reading elements from Dictionary*****");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n*****Vegetables Price List*****");
            foreach (KeyValuePair<string, int> VegPrice in VegPriceList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", VegPrice.Key, VegPrice.Value);
            }
            Console.WriteLine("\n*****Get No.of elements in Dictionary*****");
            Console.WriteLine("Count: {0}", VegPriceList.Count);

            Console.WriteLine("\n*****Update and Get a Dictionary Item*****");
            // Set Item value
            VegPriceList["Onion"] = 40;
            // Get Item value
            int price = Convert.ToInt32(VegPriceList["Onion"]);

            Console.WriteLine("\n*****Get Collection of Keys of a Dictionary Item*****");
            // Get and display keys
            Dictionary<string, int>.KeyCollection keys = VegPriceList.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            Console.WriteLine("\n*****Get Collection of Values of a Dictionary Item*****");
            // Get and display values
            Dictionary<string, int>.ValueCollection values = VegPriceList.Values;
            foreach (int val in values)
            {
                Console.WriteLine("Value: {0}", val);
            }

            Console.WriteLine("\n*****Deleting/Removing elements from Dictionary*****");
            // Remove item with key = "Cabbage"
            VegPriceList.Remove("Cabbage");
            // Remove all items
            //VegPriceList.Clear();
            Console.WriteLine("\n*****Dictionary List after CRUD operations*****");
            foreach (KeyValuePair<string, int> VegPrice in VegPriceList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", VegPrice.Key, VegPrice.Value);
            }
        }
    }
}