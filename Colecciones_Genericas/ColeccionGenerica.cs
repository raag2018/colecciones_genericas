using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Colecciones_Genericas{
    public class ColeccionGenerica{
        public  SortedDictionary<string, int> RecolectarPalabras(){
            // crea un nuevo diccionario ordenado
            SortedDictionary<string, int> diccionario =
            new SortedDictionary<string, int>();
            Console.WriteLine("Escriba una cadena: "); // pide la entrada al usuario
            string entrada = Console.ReadLine(); // obtiene la entrada
                                                 // divide el texto de entrada en símbolos (tokens)
            string[] palabras = Regex.Split(entrada, @"\s+");
            // procesamiento de las palabras de entrada
            foreach (string palabra in palabras){
                string clavePalabra = palabra.ToLower(); // obtiene palabra en minúsculas
                                                         // si el diccionario contiene la palabra
                if (diccionario.ContainsKey(clavePalabra)){
                    diccionario[clavePalabra]++;
                } // fin de if
                else
                    // agrega una nueva palabra con una cuenta de 1 al diccionario
                    diccionario.Add(clavePalabra, 1);
            } // fin de foreach
            return diccionario;
        } // fin del método RecolectarPalabras
        public void MostrarDiccionario<K, V>(SortedDictionary<K, V> diccionario){
            Console.WriteLine("\nEl diccionario ordenado contiene:\n{0,-12}{1,-12}",
           "Clave:", "Valor:");
            // genera resultados para cada clave en el diccionario ordenado,
            // mediante una iteración a través de la propiedad Keys con una instrucción
            foreach (K clave in diccionario.Keys)
                Console.WriteLine("{0,-12}{1,-12}", clave, diccionario[clave]);
            Console.WriteLine("\ntamaño: {0}", diccionario.Count);
        } // fin del método MostrarDiccionario
        public void WorkWithStrings(){
            List<string> names = ["Juan", "Ana", "Felipe"];
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1){
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }else{
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1){
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }else{
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            names.Sort();
            foreach (var name in names){
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
        public void stacks(){
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");
            foreach (string number in numbers){
                Console.WriteLine(number);
            }
            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Peek at next item to destack: {0}",
            numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());
            Stack<string> stack2 = new Stack<string>(numbers.ToArray());
            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in stack2){
                Console.WriteLine(number);
            }
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);
            Stack<string> stack3 = new Stack<string>(array2);
            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in stack3){
                Console.WriteLine(number);
            }
            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            stack2.Contains("four"));
            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }
    }
}
