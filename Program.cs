﻿using System.Collections.Generic;

namespace Proyecto_Grafos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ListaLigada> Grafo = new List<ListaLigada>();

            ListaLigada verticeA = new ListaLigada("A");
            ListaLigada verticeB = new ListaLigada("B");
            ListaLigada verticeC = new ListaLigada("C");
            ListaLigada verticeD = new ListaLigada("D");
            ListaLigada verticeE = new ListaLigada("E");
            ListaLigada verticeF = new ListaLigada("F");
            verticeA.Relacionar(verticeB);
            verticeA.Relacionar(verticeC);
            verticeA.Relacionar(verticeF);
            verticeC.Relacionar(verticeD);
            verticeD.Relacionar(verticeA);
            verticeD.Relacionar(verticeB);
            verticeE.Relacionar(verticeA);
            verticeF.Relacionar(verticeC);
            verticeF.Relacionar(verticeA);
            Grafo.Add(verticeA);
            Grafo.Add(verticeB);
            Grafo.Add(verticeC);
            Grafo.Add(verticeD);
            Grafo.Add(verticeE);
            Grafo.Add(verticeF);
        }
    }
}
