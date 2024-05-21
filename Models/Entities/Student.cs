namespace STUDENT_MVC_PROJECT.Models.Entities
{
    public class Student
    {

        //unique identify   use Guid

        public Guid id { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
        public string Phone { get; set; }
        public string Subscribe { get; set; }
    
    }
}
