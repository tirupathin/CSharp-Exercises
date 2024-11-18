// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Exercise The Triangle Farmer");

// float b = 0.00f;
// float height=0.00f;
// float area=0.00f;

// Console.WriteLine("Enter the Length of Base:");
// b = Convert.ToSingle(Console.ReadLine());
// Console.WriteLine("Enter the Length of Height:");
// height = Convert.ToSingle(Console.ReadLine());

// area = (b*height) / 2;
// Console.WriteLine($"Area of the triangle is {area} ");

Console.WriteLine("Exercise The Four Sisters and the Duckbear");
int totalChocolateEggs =0;
int eggsForEachSister =0;
int eggsForDuckbear= 0;

Console.WriteLine("Enter Total Number of Eggs: ");
totalChocolateEggs=Convert.ToInt32(Console.ReadLine());

eggsForDuckbear = totalChocolateEggs%4;
eggsForEachSister = totalChocolateEggs/4;

Console.WriteLine($"Eggs for Each Sister :  {eggsForEachSister}");
Console.WriteLine($"Eggs for Duck Bear :  {eggsForDuckbear}");