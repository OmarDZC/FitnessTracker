using System.ComponentModel.DataAnnotations;

namespace FitnessAPI.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
