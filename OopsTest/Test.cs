namespace OOPSTest;
public class Test{
public Test() : this(10)
{
Console.WriteLine("Zero args");
}


public Test(int x) : this(10, 20)
{
Console.WriteLine("Args");
}


public Test(int x, int y)
{
Console.WriteLine("Two args");
}

}
// public class Access
// public static void Main() {
//   Test obj = new Test();
// }
//}clear