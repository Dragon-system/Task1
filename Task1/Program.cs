/*Islam`s Carpert Cleaning Servise
Charges:
Sales tax rate is 6%
$25 per small
$35 per large
Estimates are valid for 30 days
*/
int smallCarpets = 25;
int largeCarpets = 35;
Console.Write("Number of small Carpets :");
int N1=Convert.ToInt32(Console.ReadLine());
Console.Write("Number of large Carpets :");
int N2=Convert.ToInt32(Console.ReadLine());
int Add= smallCarpets * N1;
int Add2 = largeCarpets * N2;
decimal X= Add + Add2;
Console.WriteLine("==========================");
Console.WriteLine(value:"Total :" + X);
decimal total = (X * 6) / 100;
decimal result = total + X;
//Console.WriteLine(value:"Result :" + result.ToString("c"));
Console.WriteLine($"Result : {result:C}");












