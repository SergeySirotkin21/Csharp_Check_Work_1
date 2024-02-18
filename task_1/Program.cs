// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] ChooseStr3el(string[] arr1)
{
    int size = 0;
    for ( int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length < 4)
        {
            size ++;    
        }
    }
    string[] arr2 = new string[size];
    int j = 0;
    for ( int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length < 4)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }
    return  arr2; 
}    
    

string[] arr = {"Hello", "2", "45", "\"world", ":-)"};
string[] array = ChooseStr3el(arr); 
System.Console.WriteLine(string.Join(", ", array));

