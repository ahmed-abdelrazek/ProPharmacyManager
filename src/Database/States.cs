using System;
using System.Windows.Forms;

namespace ProPharmacyManager.Database
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
