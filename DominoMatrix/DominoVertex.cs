using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoMatrix
{
    internal class DominoVertex
    {
        //вершина(точки)
        public string Name { get; }
        public List<DominoEdge> Edges { get;}
        public int Name1 { get; }

        public DominoVertex(string name)
        {
            Name = name;
            Edges = new List<DominoEdge>();
        }


        public void AddEdge(DominoEdge newEdge)//добавление ребер
        {
            Edges.Add(newEdge);
        }
        public void AddEdge(DominoVertex vertex)//добавление новых вершин в матрицу
        {
            AddEdge(new DominoEdge(vertex));
        }
        public override string ToString()=>Name;

    }
}
