namespace 单一职责原则;
// 错误代码
partial class A;
partial class B
{
    A OpenFile = new();
}

// 正确代码
interface IC;
partial class A : IC;
partial class B
{
    public required IC C { private get; init; }
}
class C
{
    A a;
    B b;
    C()
    {
        a = new();
        b = new() { C = a };
    }
}
// =================