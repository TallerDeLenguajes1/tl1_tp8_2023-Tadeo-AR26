using System;
using Espacio.Tarea;

//Crear arreglo de N tareas ingresadas por el usuario;

List<Tarea> TareasPendientes = new List<Tarea>();

string salir = "";
int num = 1;
do{
    Console.WriteLine("Ingrese una descripcion para la tarea");
    string DescTarea = "";
    DescTarea = Console.ReadLine();

    Tarea nuevaTarea = new Tarea();
    nuevaTarea.Descripcion = DescTarea;
    nuevaTarea.TareaID = num;
    Random random = new Random();
    nuevaTarea.Duracion = random.Next(10, 101);
    num += 1;

    TareasPendientes.Add(nuevaTarea);

    Console.WriteLine("Desea ingresar otra tarea? y/n");
    salir = Console.ReadLine();
} while(salir != "n");

foreach(Tarea tarea in TareasPendientes){
    tarea.MostrarTarea();
}
