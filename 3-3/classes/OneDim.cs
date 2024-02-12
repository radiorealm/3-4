using System;

namespace task_3_4
{
    sealed class OneDim : Parent, IOneDim
    {
        private int[] array;

        public int Length
        {
            get { return array.Length; }
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public OneDim(int n, bool entry = false) : base(entry)
        {
            array = new int[n];

            Parent.Fill();
        }

        public override void RndEntry()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
        }
        public override void UserEntry()
        {
            Console.WriteLine("Введите значения массива вручную");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }

        public override double AverageValue()
        {
            double summa = 0;
            foreach (int el in array)
            {
                summa += el;
            }
            return summa / array.Length;
        }

        public override void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }
}