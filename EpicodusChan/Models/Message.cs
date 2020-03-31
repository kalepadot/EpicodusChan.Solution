using System.ComponentModel.DataAnnotations;

namespace EpicodusChan.Models
{
  public class Message
  {
    public int MessageId { get; set; }

    public int GroupId { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Try to keep your title short!")]
    public string Title { get; set; }
    
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Entry { get; set; }

    [Required]
    public string Date { get; set; }
    
  }
}