using System;
using CS18_2;

namespace CS18
{
    public class A1
    {
        public A1()
        {
            var a2 = new A2();
            var bp = new BP();
            //var bi = new BI();  // publicではなくinternalなのでエラーになる

            var a3 = new A3();

            // A3のメソッドがアクセス修飾子によってどう見えるか検証
            a3.InternalMethod();
            a3.InternalProtectedMethod();
            a3.PublicMethod();

            // 上記の例の場合、protected と　private　が見れていない
            // protected は　自分のクラスか継承先でしか見れない
            // private は　自分のクラスでしか見れない
        }
    }

    internal class A11 : A3 // 継承した場合の挙動を確認
    {
        public A11()
        {
            //var a3 = new A3(); // 継承した場合、newで呼ばずにbaseを使用

            base.InternalMethod();
            base.InternalProtectedMethod();
            base.PublicMethod();

            base.ProtectedMethod();

        }
    }
}
