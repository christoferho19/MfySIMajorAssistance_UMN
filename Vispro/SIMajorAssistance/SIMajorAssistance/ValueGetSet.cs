using System;

namespace SIMajorAssistance
{
    internal class ValueGetSet
    {
        //Boolean cek pengisian
        public static Boolean statequestion1 { get; set; }
        public static Boolean statequestion2 { get; set; }
        public static Boolean statequestion3 { get; set; }
        public static Boolean statequestion4 { get; set; }
        public static Boolean statequestion5 { get; set; }


        //Nilai dari form new entry
        public static string nama { get; set; }

        public static string nim { get; set; }

        public static string angkatan { get; set; }

        //Nilai dari form Question 1
        public static Double if100 { get; set; }

        public static Double is100 { get; set; }

        public static Double ea100 { get; set; }

        public static Double em190 { get; set; }

        public static Double is201 { get; set; }

        public static Double is228 { get; set; }

        public static Double is240 { get; set; }

        // Nilai dari form Question 2
        public static Double is251 { get; set; }

        public static Double is255 { get; set; }

        public static Double is341 { get; set; }

        public static Double is388 { get; set; }

        public static Double ik402 { get; set; }

        public static Double is403 { get; set; }

        public static Double is431 { get; set; }

        //Nilai dari form Question 3

        public static Double is534 { get; set; }

        public static Double is545 { get; set; }

        public static Double is556 { get; set; }

        public static Double is588 { get; set; }

        //Nilai dari form Question 4
        public static Boolean TechnicalState { get; set; }
        public static Boolean AnalyticalState { get; set; }
        public static Boolean ManagerialState { get; set; }

        //Nilai dari form Question 5
        public static string minat1 { get; set; }
        public static string minat2 { get; set; }
        public static string jobofchoice { get; set; }


        //Reset
        public void resetdata()
        {
            nama = null;
            nim = null;
            angkatan = null;
            if100 = 0;
            is100 = 0;
            ea100 = 0;
            em190 = 0;
            is201 = 0;
            is228 = 0;
            is240 = 0;
            is251 = 0;
            is255 = 0;
            is341 = 0;
            is388 = 0;
            ik402 = 0;
            is403 = 0;
            is431 = 0;
            is534 = 0;
            is545 = 0;
            is556 = 0;
            is588 = 0;

            TechnicalState = false;
            AnalyticalState = false;
            ManagerialState = false;

            minat1 = null;
            minat2 = null;
            jobofchoice = null;

        }


    }
}