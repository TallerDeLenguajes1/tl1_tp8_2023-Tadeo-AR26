namespace Espacio.Tarea{
    public class Tarea{
        private int tareaID;
        private string? descripcion;
        private int duracion;

        public int TareaID { set => tareaID = value; }
        public string Descripcion { set => descripcion = value; }
        public int Duracion { set => duracion = value; }

        public void MostrarTarea(){
            Console.WriteLine($"Tarea Nº {tareaID}");
            Console.WriteLine($"Descripcion: {descripcion}");
            Console.WriteLine($"Duracion: {duracion}");
        }

    }
}