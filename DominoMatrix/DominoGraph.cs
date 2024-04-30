using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoMatrix
{
    internal class DominoGraph
    {
        public List<DominoVertex> vertices { get; }
        public DominoGraph()
        {
            vertices = new List<DominoVertex>();
        }
        public void AddVertex(string name) //добавление новой вершины
        {
            vertices.Add(new DominoVertex(name));
        }
        public DominoVertex FindVertex(string name)//поиск вершины 
        {
            foreach (var vertex in vertices)
            {
                if (vertex.Name.Equals(name)) return vertex;
            }
            return null;
        }
        public void AddEdge(string StartPoint, string FinishPoint) //создание соединения между вершинами
        {
            var v1 = FindVertex(StartPoint);
            var v2 = FindVertex(FinishPoint);
            if (v1 != null && v2 != null)
            {
                v1.AddEdge(v2);
                v2.AddEdge(v1);
            }
        }

    }
}
