

string [] studentNames = { "vishnu" , "sree", "visal" };

// print details using for loop
for (int i=0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}

// sort array
Array.Sort(studentNames);

// print details using for loop
Console.WriteLine("after sorted");

foreach (string i in studentNames)
{
    Console.WriteLine(i);
}

Console.WriteLine("maximum" + studentNames.Max());

int[] myNumbers = { 5, 1, 8, 9 };
Console.WriteLine(myNumbers.Max());  
Console.WriteLine(myNumbers.Min());  
Console.WriteLine(myNumbers.Sum());  