using System.ComponentModel.DataAnnotations;

namespace OlimpiadasUCU.Models;

public class Judge
{
  [Key]
  public String Nickname { get; set; }

  [Required]
  public String Password { get; set; }

  public String Name { get; set; }

  public String Email { get; set; }

  public String DocumentNumber { get; set; }
}