using System.ComponentModel.DataAnnotations;

namespace MyFirstWebServer.Models.PersonalDataModel;

public class PersonalDataModel
{
    [Required]
    public string? Name { get; set; }
}