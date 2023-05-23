using Dep01;
using System;

namespace DotDocs.Test.Data
{
    public class MyClass
    {
        public int MyProperty { get; set; }

        public event EventHandler MyEvent;

        MyDep01Class myField;

        public void MyMethod() { }
    }
}
