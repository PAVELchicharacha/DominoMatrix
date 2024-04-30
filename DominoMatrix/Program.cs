using DominoMatrix;

DominoGraph graph = new DominoGraph();
//graph.AddVertex("Калининград");
//graph.AddVertex("Гурьевск");
//graph.AddEdge("Калининград", "Гурьевск");
//foreach (var v in graph.vertices)
//{
//    Console.WriteLine(v + " " + v.Edges.Count);
//}
Console.WriteLine("какую по размераим матрицу вы хотите сделать?введите число от 1,до 28");
int t = int.Parse(Console.ReadLine());//выюор размера матрицы
for (int q = 0; q < t; q++)
{
    Console.WriteLine("введите наминал 2-ух сторон 1 доминошки");
    int i = int.Parse(Console.ReadLine());
    string n = i.ToString();//надо,что бы работало
    if (i < 7)
    {
        graph.AddVertex(n);
    }
    else
    {
        Console.WriteLine("номинал доминошки больше чем возможный(6)");
    }

    int j = int.Parse(Console.ReadLine());
    string x = j.ToString();//надо,что бы работало
    if (j < 7)
    {
        graph.AddVertex(x);
    }
    else
    {
        Console.WriteLine("номинал доминошки больше чем возможный(6)");
    }
    graph.AddEdge(x, n);

}
Console.WriteLine("вы создали матрицу,ее текущий вид:");
foreach (var v in graph.vertices)
{
    Console.Write(v);
}
