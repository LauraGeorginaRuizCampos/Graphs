Graphs - Implementación en C#
📌 Descripción del Proyecto

Este proyecto es una implementación de grafos dirigidos y no dirigidos en C#, utilizando listas de adyacencia para representar las conexiones entre nodos.

El objetivo principal es ofrecer al usuario la posibilidad de:

    Crear un grafo (dirigido o no dirigido).
    Agregar nodos y aristas.
    Visualizar el grafo en consola.
    Realizar recorridos BFS (Búsqueda en Anchura) y DFS (Búsqueda en Profundidad).

El programa cuenta con un menú interactivo sencillo para que el usuario pueda manipular el grafo directamente desde consola.
⚙️ Instrucciones de Instalación y Uso
✅ Requisitos

    Tener instalado Visual Studio o cualquier editor compatible con C#.
    Tener instalado .NET Framework (versión 4.7 o superior).

🚀 ¿Cómo correrlo?

    Clona el repositorio:

git clone https://github.com/LauraGeorginaRuizCampos/Graphs.git

    Abre la solución en Visual Studio.

    Compila el proyecto y ejecuta.

    En la consola, sigue las instrucciones del menú:

¿Desea que su grafo sea dirigido? (S/N)

Luego podrás:

    Agregar nodos.
    Agregar aristas.
    Visualizar el grafo.
    Realizar recorridos BFS y DFS.
    Salir del programa.

💻 Ejemplos de Entrada y Salida
🔽 Entrada:

¿Desea que su grafo sea dirigido? (S/N)
N

--- MENÚ ---
1. Agregar nodo
2. Agregar arista
3. Mostrar grafo
4. Recorrido BFS
5. Recorrido DFS
6. Salir
Seleccione una opción: 1
Ingrese el número del nodo: 1
Nodo 1 agregado.

Seleccione una opción: 2
Ingrese el nodo origen: 1
Ingrese el nodo destino: 2
Uno o ambos nodos no existen.

Seleccione una opción: 1
Ingrese el número del nodo: 2
Nodo 2 agregado.

Seleccione una opción: 2
Ingrese el nodo origen: 1
Ingrese el nodo destino: 2
Arista agregada de 1 a 2.

Seleccione una opción: 3
Grafo actual:
1 -> [ 2 ]
2 -> [ 1 ]

Seleccione una opción: 4
Ingrese el nodo de inicio para BFS: 1
Recorrido BFS:
1 2

📂 Estructura del Proyecto

Graphs/
├── Graph.cs               # Clase principal que implementa el grafo
├── Program.cs             # Contiene el menú e interacción con el usuario
└── README.md              # Documentación del proyecto

Graph.cs

    Dictionary<int, List<int>> adjacencyList: Lista de adyacencia para almacenar los nodos y sus conexiones.
    AddNode(): Agrega un nuevo nodo.
    AddEdge(): Agrega una arista entre nodos.
    Print(): Imprime el grafo actual.
    BFS(): Recorrido en anchura (no recursivo).
    DFS(): Recorrido en profundidad (no recursivo).
    ContainsNode(): Verifica si un nodo ya existe.

Program.cs

Contiene el menú principal que permite:

    Agregar nodos y aristas.
    Visualizar el grafo.
    Ejecutar los recorridos BFS y DFS.
    Salir del programa.
