int num = 14588;

if ( num < 100)
{
      Console.WriteLine("Третьей цыфры нет.");
}
 else if ( num > 100 && num < 1000)
 {
Console.WriteLine(num % 10);
 }
 else 
 { 
     while ( num > 999)
     {
      num /= 10;
     }
 Console.WriteLine( num % 10);
 }