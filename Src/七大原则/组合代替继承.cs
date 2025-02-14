namespace 组合代替继承.组合
{
    interface C
    {
        public void FunctionBase();
        public void Func1();
    }
    class A : C
    {
        public void FunctionBase() { }
        public virtual void Func1() { }
    }
    class B : C
    {
        A _a = new();
        public void FunctionBase() => _a.FunctionBase();
        public void Func1()
        {
            _a.Func1(); // Maybe
            // ... 
        }
    };
}
namespace 组合代替继承.继承
{
    // 错误代码
    class A
    {
        public void FunctionBase() { }
        public virtual void Func1() { }
    }
    class B : A
    {
        public override void Func1() { }
    };
}