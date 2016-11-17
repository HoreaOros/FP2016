using System;

namespace Curs_15_NOv
{
    struct DataCalendaristica
    {
        public int ziua;
        public int luna;
        public int anul;

        public bool Diferit(DataCalendaristica azi)
        {
            if (!(ziua == azi.ziua && luna == azi.luna && anul == azi.anul))
                return true;
            else
                return false;

            // return (ziua != azi.ziua || luna != azi.luna || anul != azi.anul);
        }

        public void ScadOZi()
        {
            if (ziua > 1)
            {
                ziua--;
            }
            else
            {
                switch (luna)
                {
                    case 1:
                        ziua = 31;
                        luna = 12;
                        anul--;
                        break;
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
                        ziua = 31;
                        luna--;
                        break;
                    case 5:
                    case 7:
                    case 10:
                    case 12:
                        ziua = 30;
                        luna--;
                        break;
                    case 3:
                        if ((anul % 4 == 0 && anul % 100 != 0) || anul % 400 == 0)
                        {
                            ziua = 29;
                        }
                        else
                        {
                            ziua = 28;
                        }
                        luna--;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}