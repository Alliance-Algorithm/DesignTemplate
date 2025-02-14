
// 错误代码
// 用户代码
namespace 开闭原则.错误代码
{

    class D
    {
        void Draw(A a)
        {
            switch (a.Type)
            {
                case 1:
                    DrawB();
                    break;
                case 2:
                    DrawC();
                    break;
                default: break;
            }
        }
        int DrawB() => 1;
        int DrawC() => 2;
    }
    // 开发者代码
    partial class A
    {
        public int Type { get; protected set; }
    };
    partial class B : A
    {
        B() => Type = 1;
    }
    partial class C : A
    {
        C() => Type = 2;
    }
    // 正确代码
}

namespace 开闭原则.正确代码
{
    class D
    {
        void Draw(A a)
        {
            a.Draw();
        }
    }

    abstract class A
    {
        public int Type { get; protected set; }
        public abstract void Draw();
    };
    partial class B : A
    {
        B() => Type = 1;

        public override void Draw() => throw new("draw a B");
    }
    partial class C : A
    {
        C() => Type = 2;
        public override void Draw() => throw new("draw a C");
    }
}