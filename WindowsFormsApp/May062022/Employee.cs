using System;


namespace WindowsFormsApp.May062022
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; } 
        public string Department { get; set; }
    }
}
