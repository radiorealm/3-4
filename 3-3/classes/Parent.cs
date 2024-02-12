using System;

namespace task_3_4
{
    abstract class Parent : IParent, IPrinter
    {
        protected static Random rnd = new Random();

        protected bool entry = false;

        private abstract void RndEntry();

        private abstract void UserEntry();

        public abstract void Print();

        public abstract double AverageValue();

        public void Fill()
        {
            if (!entry)
            {
                RndEntry();
            }
            else
            {
                UserEntry();
            }
        }
    }
}