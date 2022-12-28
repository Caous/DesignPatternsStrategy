namespace StatregyProject.Model
{
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool Active { get; set; }
        
        override
        public string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
