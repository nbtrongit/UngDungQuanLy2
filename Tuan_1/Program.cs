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

// 1
var rng = new Random();
int n = rng.Next(10, 20);
Console.WriteLine(n);

// 2
List<int> numbers = new List<int>();

for (int i = 0; i < n; i++)
{
    numbers.Add(rng.Next(5, 100));
}

// 3
for (int i = 0; i < n; i++)
{
    Console.WriteLine(numbers[i]);
}

// 4
int sum = 0;

for (int i = 0; i < n; i++)
{
    sum += numbers[i];
}

Console.WriteLine($"Tổng {sum}");

// 5
bool check = false;

for (int i = 0; i < n; i++)
{
    if (numbers[i] % 2 == 0)
    {
        check = true;
        break;
    }
}

if (check)
{
    Console.WriteLine("Toàn bộ không là số lẻ");
}
else
{
    Console.WriteLine("Toàn bộ là số lẻ");
}

// 6
int count = 0;

for (int i = 0; i < n; i++)
{
    int j = 1;
    while (true)
    {
        if (j * j == numbers[i])
        {
            count++;
            break;
        }
        else if (j * j > numbers[i])
        {
            break;
        }
        j++;
    }
}

Console.WriteLine($"Số chính phương {count}");

// 7
int max = -1;
for (int i = 0; i < n; i++)
{
    if (kiemtraSoNguyenTo(numbers[i]))
    {
        max = numbers[i];
        break;
    }
}
for (int i = 0; i < n; i++)
{
    if (kiemtraSoNguyenTo(numbers[i]) && numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine(max);
