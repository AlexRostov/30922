Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int currentValue = 2;
while(currentValue <= N)
{
    Console.Write(currentValue + " ");
    currentValue += 2;
}