namespace SampleAutomapper.Models
{
    public class StudentDTO
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";
    }
}
