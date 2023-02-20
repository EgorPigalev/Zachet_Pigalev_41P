using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public static bool CheckVIN(string vin)
        {
            try
            {
                Regex regex = new Regex("^[ABCDEFGHJKLMNPRSTUVWXYZ|0-9)]{13}[0-9]{4}$"); // Первые 13 - это символы, последние 4 - это обязательно цифры
                bool a = regex.IsMatch(vin);
                if (!a)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static string GetVINCountry(string vin)
        {
            try
            {
                if (vin[0] == 'A' || vin[0] == 'B' || vin[0] == 'C' || vin[0] == 'D' || vin[0] == 'E' || vin[0] == 'F' || vin[0] == 'G' || vin[0] == 'H')
                {
                    return "Африка";
                }
                if (vin[0] == 'J' || vin[0] == 'K' || vin[0] == 'L' || vin[0] == 'M' || vin[0] == 'N' || vin[0] == 'P' || vin[0] == 'R')
                {
                    return "Азия";
                }
                if (vin[0] == 'S' || vin[0] == 'T' || vin[0] == 'U' || vin[0] == 'V' || vin[0] == 'W' || vin[0] == 'X' || vin[0] == 'Y' || vin[0] == 'Z')
                {
                    return "Европа";
                }
                if (vin[0] == '1' || vin[0] == '2' || vin[0] == '3' || vin[0] == '4' || vin[0] == '5')
                {
                    return "Северная Америка";
                }
                if (vin[0] == '6' || vin[0] == '7')
                {
                    return "Океания";
                }
                if (vin[0] == '8' || vin[0] == '9')
                {
                    return "Южная Америка";
                }
                return "";
            }
            catch
            {
                return "";
            }

        }
    }
}
