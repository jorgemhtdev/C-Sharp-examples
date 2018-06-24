namespace Delegate
{
    using System.Collections.Generic;
    using System.Threading;

    public class Numbers
    {
        public delegate void ShowNumber(int i);

        public ShowNumber PrintNumber;

        public List<int> GetNumber(int max)
        {
            var list = new List<int>();

            for (var i = 1; i < max; i++)
            {
                PrintNumber?.Invoke(i);

                if (i % 2 != 0) continue;

                list.Add(i);
                Thread.Sleep(1000);
            }

            return list;
        }

    }
}
