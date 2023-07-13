// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int number)
{
    int firstDigit = number / 10000;
    int secondDigit = (number - firstDigit * 10000) / 1000;
    int thirdDigit = ((number - firstDigit * 10000) - secondDigit * 1000) / 100;
    int fourthDigit = (((number - firstDigit * 10000) - secondDigit * 1000) - thirdDigit * 100) / 10;
    int fifthDigit = number % 10;
    if (firstDigit == fifthDigit & secondDigit == fourthDigit) Console.WriteLine ($"Число {number} является палиндромом");
    else Console.WriteLine ($"Число {number} не является палиндромом");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput ("Введите пятизначное число: ");

Palindrome(number);

