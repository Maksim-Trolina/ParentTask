using ConsoleApp1;

try
{
    Human human = new Human() { Name = "Bob", Children = new Human[] {  new Human { Name = "Dima", Children = new Human[] { new Human { Name = "Ivan" } } }, new Human { Name = "Lol" } } };
    GetChildren(human);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}


void GetChildren(Human parent)
{
    if (parent is null)
        return;
    Console.WriteLine($"Parent name: {parent.Name}");
    DisplayChildrenNames(parent);

}

void DisplayChildrenNames(Human parent)
{
    if (parent.Children is null)
        return;
    foreach (var child in parent.Children)
    {
        if (child is not null)
        {
            Console.WriteLine($"Child name: {child.Name}");
            DisplayChildrenNames(child);
        }
    }
}