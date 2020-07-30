using System;

namespace CS18
{
    // internal は同一アセンブリのみ（同一プロジェクト）
    internal class A3
    {
        public void PublicMethod()
        { }

        internal void InternalMethod()
        { }

        protected void ProtectedMethod()
        { }

        internal protected void InternalProtectedMethod()
        { }

        private void PrivateMethod()
        { }

    }
}
