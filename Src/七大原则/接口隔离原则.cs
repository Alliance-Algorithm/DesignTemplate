namespace 接口隔离原则.正确代码
{
    interface IC { public void Func1(); }
    interface ID { public void Func1(); }
    class A : IC, ID
    {
        public void Func1() { }
        public void Func2() { }
    }
    class B(IC c)
    {
        IC _a = c;
        void Func1() { _a.Func1(); }
    }
}
namespace 接口隔离原则.错误代码
{
    interface IC { public void Func1(); }
    interface ID { public void Func1(); }
    class A : IC, ID
    {
        public void Func1() { }
        public void Func2() { }
    }
    class B()
    {
        A _a = new();
        void Func1() { _a.Func1(); }
    }
}