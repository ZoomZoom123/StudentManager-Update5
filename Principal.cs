using System;
using System.Collections.Generic;
using System.Text;


namespace StudentManager
{
    public class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying Principal");
        }
    }
}