namespace FitnessAPI.Entidades
{
    public class Entrenamiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoRutina { get; set; }
        //en relacion al usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        //en relacion al ejercicio
        public List<Ejercicio> Ejercicios { get; set; } = new List<Ejercicio>();
        
    }
}
