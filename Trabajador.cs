namespace InterfazJSON
{
    // Clase trabajador para el JSON...
    public class Trabajador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Oficio {  get; set; }
        public bool Trabajando { get; set; }

        public Trabajador(string nombre, string apellido, int edad, string oficio, bool trabajando)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Oficio = oficio;
            Trabajando = trabajando;
        }
    }
}
