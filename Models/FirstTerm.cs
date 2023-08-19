using System.ComponentModel.DataAnnotations;

namespace StajProjesi.Models;

public class FirstTerm
{
    [Key]
    public string Classname { get; set; }
    [Required]
    public int Vize { get; set; }
    [Required]
    public int FinalNt { get; set; }
    public int? Bütünleme { get; set; }

   
}

