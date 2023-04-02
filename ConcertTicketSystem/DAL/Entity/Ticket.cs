using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ConcertTicketSystem.DAL.Entity
{
    public class Ticket
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de ingreso")]
        public DateTime? UserDate { get; set; }

        [Display(Name = "estado")]
        public bool IsUsed { get; set; }


        [Display(Name = "Porteria de ingreso")]
        public string? EntranceGate { get; set; }
    }
}
