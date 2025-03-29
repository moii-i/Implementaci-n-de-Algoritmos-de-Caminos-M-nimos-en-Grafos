Implementación del Algoritmo de Dijkstra en C#

Descripción del Proyecto

Este programa implementa el algoritmo de Dijkstra para encontrar los caminos mínimos en un grafo dirigido y ponderado. Permite al usuario ingresar nodos, aristas con pesos y seleccionar un nodo inicial para calcular las distancias más cortas a los demás nodos.

Objetivo

Desarrollar una aplicación en C# que implemente el algoritmo de Dijkstra de manera sencilla, permitiendo visualizar los resultados de manera clara en la consola.

Explicación del Algoritmo

El algoritmo de Dijkstra funciona de la siguiente manera:

Se inicializan todas las distancias en infinito (INF), excepto la del nodo inicial, que es 0.

Se selecciona el nodo con la menor distancia no visitado y se marcan sus vecinos si la nueva distancia calculada es menor.

Se repite el proceso hasta que todos los nodos hayan sido visitados.

Finalmente, se imprimen las distancias mínimas desde el nodo inicial a los demás nodos.
