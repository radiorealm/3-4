using System;

namespace task_3_4
{
    abstract class Parent : IPrinter, IParent
    {
        protected static Random rnd = new Random();

        protected bool entry = false;

        protected Parent(bool entry = false)
        {
            this.entry = entry;
        }

        public abstract void RndEntry();

        public abstract void UserEntry();

        public abstract void Print();

        public abstract double AverageValue();
    }
}