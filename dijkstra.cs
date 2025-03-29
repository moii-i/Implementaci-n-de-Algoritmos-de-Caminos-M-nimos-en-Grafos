using System;
using System.Collections.Generic;

class Grafo
{
    private int nodos;
    private List<(int destino, int peso)>[] adyacencia;

    public Grafo(int n)
    {
        nodos = n;
        adyacencia = new List<(int, int)>[n];
        for (int i = 0; i < n; i++)
        {
            adyacencia[i] = new List<(int, int)>();
        }
    }

    public void AgregarArista(int origen, int destino, int peso)
    {
        adyacencia[origen].Add((destino, peso));
    }

    public void Dijkstra(int inicio)
    {
        int[] dist = new int[nodos];
        bool[] visitado = new bool[nodos];
        for (int i = 0; i < nodos; i++) dist[i] = int.MaxValue;
        dist[inicio] = 0;

        for (int i = 0; i < nodos - 1; i++)
        {
            int u = MinDistancia(dist, visitado);
            visitado[u] = true;

            foreach (var (destino, peso) in adyacencia[u])
            {
                if (!visitado[destino] && dist[u] != int.MaxValue && dist[u] + peso < dist[destino])
                {
                    dist[destino] = dist[u] + peso;
                }
            }
        }

        MostrarDistancias(dist);
    }

    private int MinDistancia(int[] dist, bool[] visitado)
    {
        int min = int.MaxValue, minIndex = -1;
        for (int i = 0; i < nodos; i++)
        {
            if (!visitado[i] && dist[i] <= min)
            {
                min = dist[i];
                minIndex = i;
            }
        }
        return minIndex;
    }

    private void MostrarDistancias(int[] dist)
    {
        Console.WriteLine("Nodo\tDistancia desde el inicio");
        for (int i = 0; i < nodos; i++)
        {
            Console.WriteLine(i + "\t" + (dist[i] == int.MaxValue ? "INF" : dist[i].ToString()));
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de nodos: ");
        int n = int.Parse(Console.ReadLine());
        Grafo g = new Grafo(n);

        Console.Write("Ingrese el número de aristas: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            Console.Write("Origen, Destino, Peso: ");
            string[] datos = Console.ReadLine().Split();
            int origen = int.Parse(datos[0]);
            int destino = int.Parse(datos[1]);
            int peso = int.Parse(datos[2]);
            g.AgregarArista(origen, destino, peso);
        }

        Console.Write("Ingrese el nodo inicial: ");
        int inicio = int.Parse(Console.ReadLine());
        g.Dijkstra(inicio);
    }
}
