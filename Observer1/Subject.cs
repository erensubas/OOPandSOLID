using System;
using System.Collections.Generic;
using System.Text;

namespace Observer1
{
    public class Subject
    {
        private int _quantity;

        public delegate void QuatityUpdated(int quantity);
        public event QuatityUpdated OnquantityUpdated;

        public void UpdateQuantity(int value)
        {
            this._quantity += value;
            OnquantityUpdated?.Invoke(this._quantity);
        }
    }
}
