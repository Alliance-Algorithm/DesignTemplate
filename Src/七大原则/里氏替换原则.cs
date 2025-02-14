namespace 里氏替换原则.错误代码
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
//正确代码 通过提取共同基类
namespace 里氏替换原则.正确代码
{
    class Base
    {
        public void FunctionBase() { }
    };
    class A : Base
    {
        public void Func1() { }
    }
    class B : Base
    {
        public void Func1() { }
    };
}
