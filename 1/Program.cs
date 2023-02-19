int abc = 399;

int a = abc / 100 ;
int c = abc % 10 ;

int result = (abc - ((a*100)+c))/10;

Console.WriteLine(result);


