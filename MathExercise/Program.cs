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

// Console.WriteLine("Exercise The Four Sisters and the Duckbear");
// int totalChocolateEggs =0;
// int eggsForEachSister =0;
// int eggsForDuckbear= 0;

// Console.WriteLine("Enter Total Number of Eggs: ");
// totalChocolateEggs=Convert.ToInt32(Console.ReadLine());

// eggsForDuckbear = totalChocolateEggs%4;
// eggsForEachSister = totalChocolateEggs/4;

// Console.WriteLine($"Eggs for Each Sister :  {eggsForEachSister}");
// Console.WriteLine($"Eggs for Duck Bear :  {eggsForDuckbear}");

// Console.WriteLine("Exercise The Dominion of Kings"); 
// int totalEstates = 0;
// int totalDuchies,totalProvinces;
// int totalPoints=0;

// Console.WriteLine("Enter Total Number of Estates: ");
// totalEstates=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Total Number of Duchies: ");
// totalDuchies=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter Total Number of Provinces: ");
// totalProvinces=Convert.ToInt32(Console.ReadLine());

// totalPoints=totalProvinces*6 + totalDuchies*3+totalEstates*1;
// Console.WriteLine($"Total Points are {totalPoints}");


// float a = 10000;
// float b = 0.00001f;
// float sum = a + b;

// Console.WriteLine("Sum is " + sum);


// Console.WriteLine("Exercise The Defense of Consolas");

// int row,col;
// Console.WriteLine("Enter Target Row?");
// row=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Target Column?");
// col=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Deploy to :");
// //Console.Beep(440,1000);
// Console.BackgroundColor =ConsoleColor.Yellow;
// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine($"({row},{col-1})");
// Console.WriteLine($"({row},{col+1})");
// Console.WriteLine($"({row-1},{col})");
// Console.WriteLine($"({row+1},{col})");

// Console.WriteLine("Exercise Repairing the Clocktower");

// int input;
// Console.WriteLine("Enter Input?");
// input = Convert.ToInt32(Console.ReadLine()) ;
// string tickortack = input%2==0 ? "Tick" : "Tock" ;
// Console.WriteLine(tickortack);

// Console.WriteLine("Exercise Watchtower");

// int x,y;
// Console.WriteLine("Enter x?");
// x = Convert.ToInt32(Console.ReadLine()) ;

// Console.WriteLine("Enter y?");
// y = Convert.ToInt32(Console.ReadLine()) ;

// string location;

// if (x == 0) 
// {
//     if (y == 0)

//     {
//         location = "!" ;
//     }
// else if (y>0) 
//     {
//         location="N";

//     }
// else
//     {
//         location = "S" ;
//     }
// } 
// else if (x<0)
// {
//     if(y<0)
//     {
//         location = "SW" ;
//     }
//     else if (y>0)
//     {
//         location = "NW" ;

//     }
//     else
//     {
//         location="W" ;
//     }
// }
// else
// {
//     if(y<0)
//     {
//         location = "SE" ;
//     }
//     else if (y>0)
//     {
//         location = "NE" ;

//     }
//     else
//     {
//         location="E" ;
//     }
// }

// Console.WriteLine($"The Enemy is in {location}");

int choice;
int price;
string item = "";
string name = "";
Console.WriteLine("Exercise Buying Inventory");

Console.WriteLine("The following items are available : \n 1 - Rope \n 2 - Torches \n 3 - Climbing Equipment \n 4 - Clean Water \n 5 - Machete \n 6 - Canoe \n 7 - Food Supplies");

Console.WriteLine("What number do you want to see the price of?");
choice = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("What is your name?");
name = Console.ReadLine();
// switch (choice)
// {
//     case 1:
//         price = 10;
//         item = "Rope";
//         break;
//     case 2:
//         price = 15;
//         item = "Torches";
//         break;
//     case 3:
//         price = 25;
//         item = "Climbing Equipment";
//         break;
//     case 4:
//         price = 1;
//         item = "Clean Water";
//         break;
//     case 5:
//         price = 20;
//         item = "Machete";
//         break;
//     case 6:
//         price = 200;
//         item = "Canoe";
//         break;
//     case 7:
//         price = 1;
//         item = "Food Supplies";
//         break;

//     default:
//         price = 0;
//         item = "Invalid Item";
//         break;


// }

(item, price) = choice switch
{
    1 => ("Rope", 10),
    2 => ("Torches", 15),
    3 => ("Climbing Equipment", 25),
    4 => ("Clean Water", 30),
    5 => ("Machete", 20),
    6 => ("Canoe", 200),
    7 => ("Food Supplies", 1),

    _ => ("Invalid Item", 0)
};

Console.WriteLine("Exercise Discounted Inventory");
if (name == "vbp")
{
    Console.WriteLine($"{item} : {price * 0.5}");
}
else
{ Console.WriteLine($"{item} : {price}"); }


Test obj = new Test();