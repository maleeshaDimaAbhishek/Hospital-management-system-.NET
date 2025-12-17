using System.ComponentModel.DataAnnotations;

public class Doctor
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Specialization { get; set; }
}