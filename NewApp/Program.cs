
using NewApp.Models.Models;

public class Program
{
    private static void Main(string[]args)
    {
        //Khoi tao doi tuong ps tu class Person
        Person ps = new Person();
        string str = "Nguyen Van A";
        int a = 22;
        ps.Display2(str, a);
    }
}