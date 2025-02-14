namespace 依赖倒置原则;
interface IC;
partial class A : IC;
partial class B
{
    public required IC C { private get; init; }
}

class C
{
    A _a;
    B _b;
    C()
    {
        _a = new();
        _b = new() { C = _a };
    }
}