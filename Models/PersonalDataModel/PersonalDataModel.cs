using System.ComponentModel.DataAnnotations;

namespace MyFirstWebServer.Models.PersonalDataModel
{
    public class PersonalDataModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Message { get; set; }
    }
}