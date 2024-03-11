// ЗАДАЧА 1
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbers(int num, int lastnum)
{
    if(num == lastnum){
            return;
        }
    
    Console.Write($"{num} ");
    PrintNumbers(num + 1, lastnum);
}

int M = 6;
int N = 14;

int firstnum = 0;
int lastnum = 0;

if(M > N){
        lastnum = M;
        firstnum = N;
    }
    else
    {
       lastnum = N;
       firstnum = M;
    }
PrintNumbers(firstnum + 1 , lastnum);

// ЗАДАЧА 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int GetA(int n, int m)
{
    if(n == 0){
        return m + 1;
    }
    if(n > 0 && m == 0){
        return GetA(n - 1,1);
    } 
    if(n > 0 && m > 0){
        return GetA(n - 1, GetA(n,m-1));
    }
    return 0;
}

Console.Write(GetA(1, 1));


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
