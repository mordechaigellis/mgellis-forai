// See https://aka.ms/new-console-template for more information

Func<int, int, int> domath = AddIt;

Console.WriteLine(domath(10,9));

domath = MultiplyIt;
Console.WriteLine(domath(10,9));

ShowMath(AddIt,1000,500);
ShowMath(MultiplyIt,1000,500);

void ShowMath(Func<int, int, int> f, int x, int y){
    Console.WriteLine(f(x,y));
}

int AddIt(int x, int y){
    return x + y;
}

int MultiplyIt(int x, int y){
    return x * y;
}