using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace kp2
{
    class Graph
    {
     public class Edge: IComparable<Edge>
        {
            public int src, dest, weigth;

            public int CompareTo(Edge compareEdge)
            {
                return this.weigth - compareEdge.weigth;
            }
        }
        public int V, E;

        public Edge[] edge;
        List<Edge> tree = new List<Edge>();


        public Graph(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[E];
            for(int i =0;i<E;i++)
            {
                edge[i] = new Edge();
            }
            

        }


        List<int> ver = new List<int>();
        public void Prima()
        {
          
            Array.Sort(edge);
            tree.Add(edge[0]);
            if(!ver.Contains(edge[0].src))
            ver.Add(edge[0].src);
            if (!ver.Contains(edge[0].dest))
                ver.Add(edge[0].dest);
          //  Console.WriteLine($"{edge[0].src}   {edge[0].dest}   {edge[0].weigth}");

            for (int i=1;i<=V;i++)
            {
                foreach (var a in ver)
                {
                ////    Console.Write($"{a} in  ver");
                    //Console.WriteLine();
                }
                if ((ver.Contains(edge[i].src)&& !ver.Contains(edge[i].dest))||(ver.Contains(edge[i].dest) && !ver.Contains(edge[i].src)))
                {
                   // Console.WriteLine($"{edge[i].src}   {edge[i].dest}   {edge[i].weigth}");
                    tree.Add(edge[i]);
                    if (!ver.Contains(edge[i].src))
                        ver.Add(edge[i].src);
                    if (!ver.Contains(edge[i].dest))
                        ver.Add(edge[i].dest);

                }
               // else
               // Console.WriteLine($"{edge[i].src}   {edge[i].dest}   {edge[i].weigth}   no   {ver.Count}");
            }

            Console.WriteLine($"edge              weight");  
            foreach (var a in tree)
            {
                Console.WriteLine($"{a.src} --  {a.dest}        {a.weigth}");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("ass");
            Graph graph = new Graph(5, 7);
            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;
            graph.edge[0].weigth = 3;

            graph.edge[1].src = 1;
            graph.edge[1].dest = 2;
            graph.edge[1].weigth = 7;

            graph.edge[2].src = 2;
            graph.edge[2].dest = 0;
            graph.edge[2].weigth = 2;

            graph.edge[3].src = 2;
            graph.edge[3].dest = 1;
            graph.edge[3].weigth = 5;

            graph.edge[4].src = 0;
            graph.edge[4].dest = 3;
            graph.edge[4].weigth = 7;

            graph.edge[5].src = 1;
            graph.edge[5].dest = 3;
            graph.edge[5].weigth = 6;

            graph.edge[6].src = 4;
            graph.edge[6].dest = 1;
            graph.edge[6].weigth = 2;



            graph.Prima();


        }
    }
}
