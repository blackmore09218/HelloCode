Console.Clear();
Console.SetBufferSize(500, 500);
int xa=80, ya=1,
    xb=1, yb=30,
    xc=160, yc=30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
int x=(xa+xb)/2;
int y=(ya+yb)/2;
int count=0;
while(count<20000)
{
    int n= new Random().Next(0, 3);
    if(n==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    if(n==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    if(n==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
    }
    count++;
}   

