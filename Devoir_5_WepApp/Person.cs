using System.ComponentModel.DataAnnotations;


namespace Devoir_5_WepApp
{

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public string FirstName { get; set; }

        public int Age { get; set; }

        public required string Gender { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        // Additional fields
        public string Email { get; set; }

        public string Occupation { get; set; }
    }

}
