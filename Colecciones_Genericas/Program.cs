﻿// crea un diccionario ordenado a partir de la entrada del usuario
using Colecciones_Genericas;
using System.Text.RegularExpressions;
var generico = new ColeccionGenerica();
// crea el diccionario ordenado, con base en la entrada del usuario
SortedDictionary<string, int> diccionario = generico.RecolectarPalabras();
// muestra el contenido del diccionario ordenado
generico.MostrarDiccionario(diccionario);
//metodo que utiliza la clase List<T>
Console.WriteLine("##################################################");
Console.WriteLine("Clase List<T>");
Console.WriteLine("##################################################");
generico.WorkWithStrings();

Console.WriteLine("##################################################");
Console.WriteLine("Clase Stack<T>");
Console.WriteLine("##################################################");
generico.stacks();