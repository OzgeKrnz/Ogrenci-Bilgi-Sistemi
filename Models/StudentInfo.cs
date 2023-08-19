using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StajProjesi.Models;

public class StudentInfo
{
    [Key]
    public string StId { get; set; }
    public string StName { get; set; }
    public string Bolum { get; set; }
    public string StEmail { get; set; }
    public double Gno { get; set; }
}