int number = 2563;
int i=1;
int n;
while (i < number)
{
    n = number % (10*i)/i;
    i=i*10;

    Console.Write(" " + n);
   
}

