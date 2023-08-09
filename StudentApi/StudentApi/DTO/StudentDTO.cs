namespace StudentApi.DTO
{
    public class StudentDTO
    {
        public int StudId { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string? Contact { get; set; }

        public string Email { get; set; } = null!;
    }
}
