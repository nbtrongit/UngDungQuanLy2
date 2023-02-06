using System.Text;

static bool kiemtraSoNguyenTo(int n)
{
    if (n <= 1)
    {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.OutputEncoding = Encoding.UTF8;

string numbers = "5, 3, 8, 11, -12, 3, 11, 28, 30";
string[] numbersArr = numbers.Split(", ");
List<int> numbersL = new List<int>();

for (int i = 0; i < numbersArr.Length; i++)
{
    numbersL.Add(int.Parse(numbersArr[i]));
}
List<int> primeNumbers = new List<int>();
List<int> evenNumbers = new List<int>();
int min = numbersL[0];
int max = numbersL[0];

for (int i = 0; i < numbersL.Count; i++)
{
    if (numbersL[i] < min)
    {
        min = numbersL[i];
    }
    if (numbersL[i] > max)
    {
        max = numbersL[i];
    }
    if (kiemtraSoNguyenTo(numbersL[i]))
    {
        primeNumbers.Add(numbersL[i]);
    }
    if (numbersL[i] % 2 == 0)
    {
        evenNumbers.Add(numbersL[i]);
    }
}
List<int> numbersLD = primeNumbers.Distinct().ToList();

Console.WriteLine("Các số nguyên tố trong mảng");

for (int i = 0; i < numbersLD.Count; i++)
{
    Console.Write($"{numbersLD[i]} ");
}

Console.WriteLine();

numbersLD = evenNumbers.Distinct().ToList();

Console.WriteLine("Các số chẵn trong mảng");

for (int i = 0; i < numbersLD.Count; i++)
{
    Console.Write($"{numbersLD[i]} ");
}

Console.WriteLine();

Console.WriteLine($"Số lớn nhất {max}");
Console.WriteLine($"Số nhỏ nhất {min}");