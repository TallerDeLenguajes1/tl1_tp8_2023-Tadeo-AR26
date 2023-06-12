using System;

string path = @"C:\Catedras_facultad\TallerDeLenguajes\tl1_tp8_2023-Tadeo-AR26";
List<string> archivos = Directory.GetFiles(path).ToList();

StreamWriter sw = new StreamWriter("index.csv");
int i = 1;

foreach (var archivo in archivos){
    sw.WriteLine($"{i},{Path.GetFileNameWithoutExtension(archivo)},{Path.GetExtension(archivo)}");
    i += 1;
}

sw.Close();