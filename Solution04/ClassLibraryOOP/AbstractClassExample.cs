using System;

namespace ClassLibraryOOP
{
    public abstract class AbstractClass
    {
        public abstract void DoWork();
        public int x;
        public abstract int Y { get; set; }

        public AbstractClass()
        {

        }
        public AbstractClass(int x)
        {
            this.x = x;
        }

        //No abstract ctor.
        //public abstract AbstractClassABS(int x, int y, int z);

        public virtual void VirtMethod()
        {

        }

    }

    public class InheritedClass1 : AbstractClass
    {
        public override void DoWork()
        {
            throw new NotImplementedException();
        }

        public override int Y
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
    }
}
