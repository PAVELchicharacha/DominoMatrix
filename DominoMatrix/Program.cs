using DominoMatrix;

DominoGraph graph = new DominoGraph();
//graph.AddVertex("Калининград");
//graph.AddVertex("Гурьевск");
//graph.AddEdge("Калининград", "Гурьевск");
//foreach (var v in graph.vertices)
//{
//    Console.WriteLine(v + " " + v.Edges.Count);
//}
Console.WriteLine("введите наминал 2-ух сторон 1 доминошки");

int i = int.Parse(Console.ReadLine());
if (i <= 7)
{
    
}
int j = int.Parse(Console.ReadLine());
if (j <= 7)
{
    
}
foreach (var v in graph.vertices)
{
    Console.WriteLine(v + " " + v.Edges.Count);
}
