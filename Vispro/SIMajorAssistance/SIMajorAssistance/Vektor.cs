using System;

namespace SIMajorAssistance
{
    internal class Vektor
    {
        //Nilai Vektor S
        public static Double sitgov { get; set; }

        public static Double sdb { get; set; }
        public static Double serp { get; set; }
        public static Double sbd { get; set; }

        //Nilai Vektor
        public static Double vitgov { get; set; }

        public static Double vdb { get; set; }
        public static Double verp { get; set; }
        public static Double vbd { get; set; }

        //Hasil
        public static string first { get; set; }

        public static string second { get; set; }
        public static string third { get; set; }
        public static string last { get; set; }

        public void resetdata()
        {
            sitgov = 0;
            sdb = 0;
            sbd = 0;
            serp = 0;

            vitgov = 0;
            vdb = 0;
            vbd = 0;
            verp = 0;

            first = null;
            second = null;
            third = null;
            last = null;
        }
    }
}