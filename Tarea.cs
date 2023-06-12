namespace Espacio.Tarea{
    public class Tarea{
        private int tareaID;
        private string? descripcion;
        private int duracion;

   
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int TareaID { get => tareaID; set => tareaID = value; }

        public void MostrarTarea(){
            Console.WriteLine($"Tarea Nº {TareaID}");
            Console.WriteLine($"Descripcion: {descripcion}");
            Console.WriteLine($"Duracion: {duracion}");
        }

    }
}