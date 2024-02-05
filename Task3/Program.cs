// Задайте произвольную строку. Выясните,
// является ли она палиндромом

bool CheckPalindrome(string str)
{
    for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++,j--)
        {
            if (str[i] != str[j])
            {
                return false;
            }
        }
    return true;
}
Console.Write("Введите строку на проверку:");
string str = Console.ReadLine();
str = str.ToLower();
bool isPalindrome = CheckPalindrome(str);

if (isPalindrome)
{
    Console.WriteLine("ДА строчка является полиндромом");
}
else
{
    Console.WriteLine("Нет, строчка не является полиндромом");
}