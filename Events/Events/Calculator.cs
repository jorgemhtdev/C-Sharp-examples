namespace Events
{
    using System;

    public class Calculator
    {
        #region delegate
        public delegate void DivideByZeroEventHandler(object sender, DivideByZeroEventArgs e);
        #endregion

        #region event
        public event DivideByZeroEventHandler DivideByZero;
        #endregion

        //public event EventHandler DivideByZero; 

        public int Divide(int a, int b)
        {
            var result = 0;

            if (b == 0) DivideByZero?.Invoke(this, new DivideByZeroEventArgs { a = a, b = b });
            else result = a / b;
            return result;
        }

        public class DivideByZeroEventArgs : EventArgs
        {
            public int a { get; set; }
            public int b { get; set; }
        }
    }
}
