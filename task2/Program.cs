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
