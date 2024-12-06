using ConsoleApp1;



//Shape[] shapes = { new Circle(), new Triangle(), new Rectangle() };

//foreach (Shape shape in shapes)
//{
//    shape.Draw();
//}

static void DisplayElements(List<int> list)
{
    Console.WriteLine("**List**");

    foreach (int item in list)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}

List<int> intList = new List<int>() { 1,5,2,6,24,2,64,5,150,7};
DisplayElements(intList);

Console.WriteLine("New element:");
string userInput = Console.ReadLine();
int userInputInt = int.Parse(userInput);
intList.Add(userInputInt);
DisplayElements(intList);
Console.WriteLine("Remove range");
intList.RemoveRange(1, 2);
DisplayElements(intList);
Console.WriteLine("sort");
intList.Sort();
DisplayElements(intList);