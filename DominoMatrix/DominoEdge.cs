using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoMatrix
{
    internal class DominoEdge
    {
        //ребро(соединялка для точек)
        public DominoVertex ConVertex { get; }
       

        public DominoEdge(DominoVertex convertex)//конструктор класса DominoEdge, который принимает один аргумент типа DominoVertex и присваивает его полю ConVertex класса DominoEdge.
        {
            ConVertex = convertex;
        }
    }
}
