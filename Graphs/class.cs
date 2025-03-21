using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class Graph
    {
        // Diccionario para representar el grafo como lista de adyacencia
        // La clave es el nodo, y el valor es la lista de vecinos (nodos conectados)
        public Dictionary<int, List<int>> adjacencyList;

        // Bandera para saber si el grafo es dirigido (true) o no dirigido (false)
        private bool isDirected;

        // Constructor del grafo: recibe si es dirigido o no
        public Graph(bool isDirected)
        {
            adjacencyList = new Dictionary<int, List<int>>(); // Inicializa el diccionario vacío
            this.isDirected = isDirected; // Guarda si es dirigido
        }

        // Método para agregar un nodo al grafo
        public void AddNode(int node)
        {
            // Crea una nueva entrada en el diccionario para el nodo con lista vacía
            if(!adjacencyList.ContainsKey(node))
                adjacencyList.Add(node, new List<int>());
        }

        // Método para agregar una arista entre dos nodos
        public void AddEdge(int source, int destination)
        {
            // Agrega el destino a la lista de adyacencia del nodo origen
            adjacencyList[source].Add(destination);

            // Si el grafo NO es dirigido, también agrega la arista inversa
            if (!isDirected)
            {
                adjacencyList[destination].Add(source);
            }
        }

        // Método para imprimir el grafo en consola
        public void Print()
        {
            // Recorre cada nodo y sus vecinos
            foreach (KeyValuePair<int, List<int>> entry in adjacencyList)
            {
                Console.Write(entry.Key + " -> [");
                for (int i = 0; i < entry.Value.Count; i++)
                {
                    Console.Write(" " + entry.Value[i] + " "); // Imprime cada vecino
                }
                Console.WriteLine("]");
            }
        }

        // Método para recorrer el grafo usando Búsqueda en Anchura (BFS)
        public void BFS(int start)
        {
            // Verifica si el nodo existe en el grafo
            if (!adjacencyList.ContainsKey(start))
            {
                Console.WriteLine($"El nodo {start} no existe.");
                return;
            }

            List<int> visited = new List<int>(); // Lista para marcar nodos visitados
            Queue<int> queue = new Queue<int>(); // Cola para BFS (FIFO)

            visited.Add(start); // Marca el nodo inicial como visitado
            queue.Enqueue(start); // Agrega el nodo inicial a la cola

            Console.WriteLine("Recorrido BFS:");

            // Mientras haya nodos en la cola
            while (queue.Count > 0)
            {
                int current = queue.Dequeue(); // Saca el primer nodo de la cola
                Console.Write(current + " "); // Imprime el nodo

                // Recorre todos los vecinos del nodo actual
                foreach (int neighbor in adjacencyList[current])
                {
                    // Si el vecino no ha sido visitado
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor); // Lo marca como visitado
                        queue.Enqueue(neighbor); // Lo agrega a la cola
                    }
                }
            }

            Console.WriteLine(); // Salto de línea
        }

        // Método para recorrer el grafo usando Búsqueda en Profundidad (DFS)
        public void DFS(int start)
        {
            // Verifica si el nodo existe
            if (!adjacencyList.ContainsKey(start))
            {
                Console.WriteLine($"El nodo {start} no existe.");
                return;
            }

            List<int> visited = new List<int>(); // Lista para marcar visitados

            Console.WriteLine("Recorrido DFS:");
            DFSUtil(start, visited); // Llama a la función recursiva auxiliar
            Console.WriteLine();
        }

        // Función auxiliar recursiva para DFS
        private void DFSUtil(int node, List<int> visited)
        {
            visited.Add(node); // Marca el nodo como visitado
            Console.Write(node + " "); // Imprime el nodo

            // Recorre todos los vecinos del nodo
            foreach (int neighbor in adjacencyList[node])
            {
                // Si no ha sido visitado, llama recursivamente
                if (!visited.Contains(neighbor))
                {
                    DFSUtil(neighbor, visited);
                }
            }
        }

        public bool ContainsNode(int node)
        {
            return adjacencyList.ContainsKey(node);
        }
    }
}