int a = 7;
int b = 2;
int c = 3;

int max = a;

if (b > max) max =b;
if (c > max) max =c;

System.Console.WriteLine(max);

a = 44;
b = 5;
c = 78;

if (b > max) max =b;
if (c > max) max =c;

System.Console.WriteLine(max);

