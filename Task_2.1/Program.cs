int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

double res = Math.Log(b);

int fact = 1;
for (int x = 1; x <= a; x++)
{
    fact *= x;
}
Console.WriteLine(
    (fact > res ? 
        $"Number 'a' = {fact * 0.05:0.00} and more than number 'b'= {res:0.00}"
        : $"Number 'a' = {fact * 0.05:0.00} and less than number 'b' = {res:0.00}"));
