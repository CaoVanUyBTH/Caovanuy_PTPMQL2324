namespace testapp.test
{
    public class Student : test
    {
        public string StudentID { get; set; }
        public void EnterData()
        {
        base.EnterData();
        System.Console.Write("Student ID = ");
        StudentID = Console.ReadLine();
        }
        public void Display()
        {
            base.Display();
            System.Console.Write("_Ma sinh vien: {0}", StudentID);
        }
    }
}