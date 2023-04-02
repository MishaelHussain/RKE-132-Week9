string folderPath = @"C:\data";
string fileName = "shppingList.txt";
string filePath = Path.Combine(folderPath, fileName);   
List<string> files = new List<string>();    


if (File.Exists(filePath))
{
    List<string> myShoppingList = GetItemsFromUser(); 
    File.WriteAllLines(filePath, myShoppingList);
} 
else
{
    Console.WriteLine(filepath).Close();
    Console.Writleline($"File {fileName} has been created.");
}




List<string> myShoppingList = GetItemsFromUser();
ShowItemsFromList(myShoppingList);








static List<string> GetItemsFromUser()
{
    List<string> myShoppingList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine("Enter an item:");
            string userItem = Console.ReadLine();
            myShoppingList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }

    } 
    return myShoppingList;
}


static void ShowItemsFromList(List<string> somelist)
{
    Console.Clear();


    int listLenght = somelist.Count;
    Console.WriteLine($"You have added {listLenght} items to your shopping list.");


    int i = 1;
    foreach (string item in somelist)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}
