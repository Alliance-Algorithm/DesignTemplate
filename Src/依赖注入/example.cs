namespace 依赖注入;

interface IA;
interface IB;
interface IC;

class A : IA;
class B : IB;
class C : IC;

class FuncStyle
{
    IA? _a;
    IB? _b;
    IC? _c;
    public FuncStyle SetA(IA a)
    {
        _a = a;
        return this;
    }
    public FuncStyle SetB(IB b)
    {
        _b = b;
        return this;
    }
    public FuncStyle SetC(IC c)
    {
        _c = c;
        return this;
    }
}

class InitializerStyle
{
    public required IA _a { private get; init; }
    public required IB _b { private get; init; }
    public required IC _c { private get; init; }
}
class Example()
{
    FuncStyle _a = new FuncStyle().
                        SetA(new A()).
                        SetB(new B()).
                        SetC(new C());

    InitializerStyle _b = new()
    {
        _a = new A(),
        _b = new B(),
        _c = new C()
    };
}