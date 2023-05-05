// Minh walked me through this assignment 

Console.WriteLine("Hello World");

// 1. Iterate and print values: Given a List of strings, iterate through the List and print out all the values. 
// Bonus: How many different ways can you find to print out the contents of a List? (There are at least 3! Check Google!)
static void PrintList(List<string> MyList)
{
    // Your code here
    MyList.ForEach(name=>Console.WriteLine(name));
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

// 2. Print Sum: Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{
    // Your code here
    Console.WriteLine(IntList.Sum());
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
SumOfNumbers(TestIntList);
// void = no return so we console.writeline inside the function 

// 3. Find Max: Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> IntList)
{
    // Your code here
    return IntList.Max();
    // IntList.Max = going through list and finding the max value 
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
Console.WriteLine(FindMax(TestIntList2));

// 4. Square the values: Given a List of integers, return the List with all the values squared.
static List<int> SquareValues(List<int> IntList)
{
    // Your code here
    return IntList.Select(num => num * num).ToList();
    // .Select = going through the list of numbers
    // arrow function is creating the value squared 
    // .ToList = returning the list of numbers 
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
Console.WriteLine(string.Join(",", SquareValues(TestIntList3)));

// 5. Replace negative numbers with 0: Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    // Your code here
    return IntArray.Select(num => num< 0 ? 0:num).ToArray();
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
Console.WriteLine(string.Join(",", NonNegatives(TestIntArray)));
// .Join = concatenates 

// 6. Print Dictionary: Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    // Your code here
    Console.WriteLine(string.Join(", ", MyDictionary.Select(name => name.Key + ": " + name.Value)));
    // using arrow function to join key and value by selecting the key/value pairs in MyDictionary 
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// 7. Find Key: Given a search term, return true or false whether the given term is a key in a dictionary. 
// (Hint: figuring this one out may require some research!)
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
// bool will return true or false 
{
    // Your code here
    return MyDictionary.ContainsKey(SearchTerm);
    // just seeing if the key exists 
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// 8. Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    return Names.Select((name, idx)=> new {Key = name, Value = Numbers[idx]}).ToDictionary(item=>item.Key, item=>item.Value);
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
List<string> keys =  new List<string> {"Julie", "Harold", "James", "Monica"};
List<int> values = new List<int> {6, 12, 7, 10};
// creating new lists: key = list of names given / value = list of int given 
Dictionary<string, int> output = GenerateDictionary(keys, values);
Console.WriteLine(string.Join("\n", output.Select(item => item.Key + ": " + item.Value)));
// \n = windows line seperator (creates multiple lines instead of showing outcome all in one line)
