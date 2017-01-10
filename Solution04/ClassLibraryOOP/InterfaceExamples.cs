using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryOOP
{
    public class BaseClass
    { }

    public interface IMyInterface
    {
        int MyProperty { get; set; }
        void DoWork();
    }

    public interface IMyInterface1
    {
    }

    public class ClassWithInterfaces : BaseClass, IMyInterface, IMyInterface1
    {
        public int MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }

    public interface I
    {
        void F();
        int X { get; set; }
    }

    public class A : I
    {
        public int X
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void F()
        {
            throw new NotImplementedException();
        }

        public int Y { get; set; }
        public void F1() { }

    }

    public class B : I
    {
        public int Z { get; set; }
        public void F2() { }

        public int X
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void F()
        {
            throw new NotImplementedException();
        }
    }

    public class Programm
    {
        public void Main()
        {
            var a = new A();
            var b = new B();

            DoWork(a);
            DoWork(b);
            
        }

        public void DoWork(I value)
        {
            Console.WriteLine(value.X);
            value.F();
        }

    }
}
