namespace testapp.test
{
    public class test
    {
        public int TestID {get; set;}
        public string TestName {get; set;}
        public string TestDiachi {get; set;} 
        public void Display()
        {
            System.Console.WriteLine("{0} - {1} - {2}", TestID, TestDiachi, TestName);
        }

    }
}