// See https://aka.ms/new-console-template for more information

Func<int, int, int> domath = AddIt;

var divideIt = (int x, int y) => x/y;

Console.WriteLine(domath(10,9));

domath = MultiplyIt;
Console.WriteLine(domath(10,9));

ShowMath(AddIt,1000,500);
ShowMath(MultiplyIt,1000,500);
ShowMath(divideIt,900,10);

ShowMath((int x, int y)=>x-y,100,1);

void ShowMath(Func<int, int, int> f, int x, int y){
    Console.WriteLine(f(x,y));
}

int AddIt(int x, int y){
    return x + y;
}

int MultiplyIt(int x, int y){
    return x * y;
}