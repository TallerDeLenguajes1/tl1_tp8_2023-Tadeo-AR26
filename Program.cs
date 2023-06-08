using System;
using Espacio.Tarea;

//Crear arreglo de N tareas ingresadas por el usuario;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();

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


Console.WriteLine("Desea marcar una tarea como realizada? y/n");
salir = Console.ReadLine();
do{
    Console.WriteLine("Ingrese el ID de la tarea que desea marcar como realizada");
    int id = 0;
    bool control = int.TryParse(Console.ReadLine(), out id);

    foreach(Tarea tarea in TareasPendientes){
        if(tarea.TareaID == id){
            TareasRealizadas.Add(tarea);
        }
    }
     foreach(Tarea tarea in TareasRealizadas){
        TareasPendientes.Remove(tarea);
    }

    Console.WriteLine("Desea marcar otra tarea como realizada? y/n");
    salir = Console.ReadLine();
}while(salir != "n");

Console.WriteLine("******* TAREAS PENDIENTES *******");
foreach(Tarea tarea in TareasPendientes){
    tarea.MostrarTarea();
}

Console.WriteLine("******* TAREAS REALIZADAS *******");
foreach(Tarea tarea in TareasRealizadas){
    tarea.MostrarTarea();
}