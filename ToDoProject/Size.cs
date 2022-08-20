using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject
{
   internal static class SizeManager
    {
        internal static Size GetSizeEnum(string number)
        {
            switch (number)
            {
                case "1":
                    return Size.XS;
                case "2":
                    return Size.S;
                case "3":
                    return Size.M;
                case "4":
                    return Size.L;
                case "5":
                    return Size.XL;
                default:
                    throw new Exception("Geçersiz Seçim");
            }
        }

    }
        internal enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}

