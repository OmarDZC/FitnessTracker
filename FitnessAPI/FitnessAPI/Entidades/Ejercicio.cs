namespace FitnessAPI.Entidades
{
    public class Ejercicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Series { get; set; }
        public double PesoMaximo { get; set; }
        public bool Dropset { get; set; }
        public bool RestPause { get; set; }
        //relacion con entrenamiento
        public int EntrenamientoId { get; set; }
        public Entrenamiento Entrenamiento { get; set; }
    }
}
