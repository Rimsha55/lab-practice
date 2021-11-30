using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public interface Employee
    {
        event System.EventHandler Calculatepay;

        double CalculatePay { get; set; }
    }
}