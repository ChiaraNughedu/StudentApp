using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Studente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Cognome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataDiNascita { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
