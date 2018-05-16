using System;
using System.Windows.Forms;

namespace PharmacyProManager.Database
{
    class States
    {
        public enum AccountState : byte
        {
            Employee = 1,
            Manager = 2,
            None = 0
        }
    }
}
