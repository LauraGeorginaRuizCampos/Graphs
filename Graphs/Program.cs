using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Desea que su grafo sea dirigido? (S/N)");
            string respuesta = Console.ReadLine();
            bool isDirected;

            if (respuesta == "S" || respuesta == "s")
            {
                isDirected = true;
            }
            else
            {
                isDirected = false;
            }

            Graph graph = new Graph(isDirected);

            int opcion = 0;

            do
            {
                Console.WriteLine("\n--- MENÚ ---");
                Console.WriteLine("1. Agregar nodo");
                Console.WriteLine("2. Agregar arista");
                Console.WriteLine("3. Mostrar grafo");
                Console.WriteLine("4. Recorrido BFS");
                Console.WriteLine("5. Recorrido DFS");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Opción inválida, intenta de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número del nodo: ");
                        int nodo;
                        if (int.TryParse(Console.ReadLine(), out nodo))
                        {
                            if (!graph.ContainsNode(nodo)) // Usamos el método
                            {
                                graph.AddNode(nodo);
                                Console.WriteLine($"Nodo {nodo} agregado.");
                            }
                            else
                            {
                                Console.WriteLine("Ese nodo ya existe.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el nodo origen: ");
                        int origen;
                        if (int.TryParse(Console.ReadLine(), out origen))
                        {
                            Console.Write("Ingrese el nodo destino: ");
                            int destino;
                            if (int.TryParse(Console.ReadLine(), out destino))
                            {
                                if (graph.ContainsNode(origen) && graph.ContainsNode(destino)) // Validamos
                                {
                                    graph.AddEdge(origen, destino);
                                    Console.WriteLine($"Arista agregada de {origen} a {destino}.");
                                }
                                else
                                {
                                    Console.WriteLine("Uno o ambos nodos no existen.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Grafo actual:");
                        graph.Print();
                        break;

                    case 4:
                        Console.Write("Ingrese el nodo de inicio para BFS: ");
                        int startBFS;
                        if (int.TryParse(Console.ReadLine(), out startBFS))
                        {
                            graph.BFS(startBFS);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 5:
                        Console.Write("Ingrese el nodo de inicio para DFS: ");
                        int startDFS;
                        if (int.TryParse(Console.ReadLine(), out startDFS))
                        {
                            graph.DFS(startDFS);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
