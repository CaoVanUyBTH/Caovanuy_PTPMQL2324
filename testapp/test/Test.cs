using System.Security.AccessControl;
namespace testapp.test
{
    public class test
    {
        public int TestID {get; set;}
        public string TestName {get; set;}
        public string TestDiachi {get; set;} 
        public void EnterData()
        {
            System.Console.Write("TestID = ");
            TestID = Console.Read();
            System.Console.Write("TestName = ");
            TestName = Console.ReadLine();
            System.Console.Write("TestDiachi = ");
            TestDiachi = Console.ReadLine();

        }
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", TestID, TestDiachi, TestName);
        }
    }
}