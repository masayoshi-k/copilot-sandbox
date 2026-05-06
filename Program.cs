// See https://aka.ms/new-console-template for more information

// ユーザーが入力した数字を3倍にして返す関数
static int MultiplyByThree(int number)
{
    return number * 3;
}

Console.Write("数字を入力してください: ");
string? input = Console.ReadLine();
if (input != null && int.TryParse(input, out int number))
{
    int result = MultiplyByThree(number);
    Console.WriteLine($"3倍の値: {result}");
}
else
{
    Console.WriteLine("有効な数字を入力してください。");
}
