using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalcEngine
{
    public class DiscountCalculator
    {
        String state = "NA";
        String profession = "NA";
        Boolean isSeniorCitizen = false;

        public string State { get => state; set => state = value; }
        public string Profession { get => profession; set => profession = value; }
        public bool IsSeniorCitizen { get => isSeniorCitizen; set => isSeniorCitizen = value; }

        public int calculateDiscount()
        {
            if (IsSeniorCitizen)
            {
                Debug.WriteLine("Senior Citizen rate");
                return 15;
            }

            switch (State.ToUpper())
            {
                case "NJ":
                case "PA":
                    Debug.WriteLine("Preferred state");
                    return 10;
                default:
                    break;
            }

            switch (Profession.ToUpper())
            {
                case "DEVELOPER":
                    Debug.WriteLine("Developer!!!");
                    return 10;
                default:
                    break;
            }

            return 5;
        }
    }
}
