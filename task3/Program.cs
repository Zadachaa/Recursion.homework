// ЗАДАЧА 3
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int [] CreateRandomArray(int min, int max, int size){
    int [] array = new int [size];
    for(int i=0; i<size; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

void TurnArray(int [] array, int i)
{
    if(i < 0){
        return;
    }
    
    Console.Write(array[i]);
    TurnArray(array, i - 1);
}

void PrintArray(int [] array) {
    foreach (int entry in array) {
        Console.Write(entry);
    }
}

int [] array = CreateRandomArray(1, 5, 7);
PrintArray(array);
Console.WriteLine("\n");
TurnArray(array, array.Length - 1);
Console.WriteLine("\n");
