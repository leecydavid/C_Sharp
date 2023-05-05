Console.WriteLine("Hello World");

    // **********Basic Arrays************

//Create an integer array with the values 0 through 9 inside.
int[]Array1 = new int[] {0,1,2,3,4,5,6,7,8,9};
// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
string[]Array2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};
// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true.
bool[]Array3 = new bool[10];
for (int i = 0; i < Array3.Length; i++)
    Array3[i] = i == 0 ? !Array3[i]:!Array3[i-1];

Array.ForEach(Array1, Console.WriteLine);
Array.ForEach(Array2, Console.WriteLine);
Array.ForEach(Array3, Console.WriteLine);

    // ********List of Flavors**********

// Create a string List of ice cream flavors that holds at least 5 different flavors.
List<string> flavors =  new List<string> {"Choco", "Vanilla", "Lilikoi", "Rocky", "Beer"};
// flavors.Add("Honey");
// Output the length of the List after you added the flavors.
Console.WriteLine(flavors.Count);
// Output the third flavor in the List.
Console.WriteLine(flavors[2]);
for (int idx=0; idx<flavors.Count; idx++)
{
    Console.WriteLine(flavors[idx]);
}
Console.WriteLine("******************************");
// Now remove the third flavor using its index location.
flavors.RemoveAt(2);
for (int idx=0; idx<flavors.Count; idx++)
{
    Console.WriteLine(flavors[idx]);
}
// Output length of list again
Console.WriteLine(flavors.Count);

    // **********User Dictionary************

// Create a dictionary that will store string keys and string values
// Add key/value pairs to the dictionary where: Each key is a name from your names array (this can be done by hand or using logic)
// Add key/value pairs to the dictionary where: Each value is a randomly selected flavor from your flavors List
Dictionary<string,string> customers = new Dictionary<string, string>();
foreach (string name in Array2)
{
    customers.Add(name, null);
}
Random rand = new Random();
foreach (var name in Array2)
{
    int randIndx = rand.Next(flavors.Count);
    customers[name] = flavors[randIndx];
    flavors.RemoveAt(randIndx);
}
foreach (KeyValuePair<string,string> output in customers)
{
    Console.WriteLine($"{output.Key} - {output.Value}");
}





























