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
