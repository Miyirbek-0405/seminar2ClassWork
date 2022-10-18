// Напишите программу, которая выводит случайное  число из отрезка [10, 99]и показывает наибольшую цифру числа

/* 
int randomNum = new Random().Next(10, 100);
int CheckBiggestNum(int number)
{
    int dec = number / 10;
    int ed = number % 10;
    if (dec > ed)
    {
        return dec;
    }
    else
    {
        return ed;
    }
}
int result = CheckBiggestNum(randomNum);
Console.WriteLine($"Check randomNum {randomNum} is big {result}"); 
*/

// ===============================================================================================

// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int radnNum = new Random().Next(100, 1000);
int DeleteSecondNumber(int number)
{
    int sto = number / 100;
    int ed = number % 10;
    int res = sto * 10 + ed;
    return res;
}
int result = DeleteSecondNumber(radnNum);

Console.WriteLine($"Check randomNum {radnNum} is big {result}");
*/
// ==========================================================================================

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления

/*
Console.WriteLine("Введите первое число: ");
int numA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB=Convert.ToInt32(Console.ReadLine());

void  MultiplayNum(int num1,int num2){
    if(num2%num1==0){
        Console.WriteLine("кратно");
    }
    else{
        Console.WriteLine($"остаток от деления {num2%num1}");
    }
}

MultiplayNum(numA,numB);
*/

// =====================================================================================================

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

Console.WriteLine("Введите первое число: ");
int numA=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numC=Convert.ToInt32(Console.ReadLine());

void MultiplayTwoOneTime (int num,int a,int b){
    if(num%a==0 & num%b==0){
        Console.WriteLine("кратко одновременно");
    }else{
        Console.WriteLine("не кратко");
    }
}
MultiplayTwoOneTime(numA,numB,numC);


// =======================================================================================================

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
