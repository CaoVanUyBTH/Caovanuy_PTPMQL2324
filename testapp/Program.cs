using testapp.test;

public class Program
{
    public static void Main(string[] args)
    {
        test Test1 = new test();
        test Test2 = new test();
        test Test3 = new test();
        test Test4 = new test();
        test Test5 = new test();
        Test4.TestName = "Nguyen Van A";
        Test3.TestDiachi = "Pham Hung";
        Test2.TestName = "Pham Nhat Vuong";
        Test2.Display();
    }
}
