// 1. Verilmiş ədədin 2-in neçənci qüvvəti (və ya neçənci qüvvətinə yaxın) olduğunu tapın.
int num = 25;
int say = 0;
int number = 0;
for (int i = 2; i <= num; i *= 2)
{
    say++;
    number = i;

}
if ((num - number) <= (2 * number - num))
{
    Console.WriteLine(say);
}
else if ((num - number) > (2 * number - num))
{
    say++;
    Console.WriteLine(say);
    Console.ReadLine();
}


// 2. Ədədin rəqəmləri cəmini tapın.
int num = 12345;
int sum = 0;
int r = 1;
while (num != 0)
{
    r = num % 10;
    sum = sum + r;
    num = num / 10;
}
Console.WriteLine(sum);
Console.ReadLine();


// 3. Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın.

int say = 0;
int num = 12;
for (int i = 1; i <= num; i++)
{
    if (num%i==0)
    {
        say++;
    }
}
if (say > 2)
{
    Console.WriteLine("Murekkeb ededdir");
    Console.ReadLine();
}
else
{
    Console.WriteLine("Sade ededdir");
    Console.ReadLine();
}