using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class benefit : emp, Employee
    {
        public int healthinsurance
        {
            get => default;
            set
            {
            }
        }

        public int lifeinsurance
        {
            get => default;
            set
            {
            }
        }

        public int vacation
        {
            get => default;
            set
            {
            }
        }

        public void Benefit(string inhealth, double inlife, int invacation)
        {
            throw new System.NotImplementedException();
        }

        public void Benefit()
        {
            throw new System.NotImplementedException();
        }

        public void DisplayBenefit()
        {
            throw new System.NotImplementedException();
        }

        public string getHealthinsurance()
        {
            throw new System.NotImplementedException();
        }

        public void getHealthinsurance(string inhins)
        {
            throw new System.NotImplementedException();
        }

        public void getLifeinsurance()
        {
            throw new System.NotImplementedException();
        }

        public void getLifeinsurance(double inlife)
        {
            throw new System.NotImplementedException();
        }

        public int getVacation()
        {
            throw new System.NotImplementedException();
        }

        public void getVacation(int invaca)
        {
            throw new System.NotImplementedException();
        }
    }
}