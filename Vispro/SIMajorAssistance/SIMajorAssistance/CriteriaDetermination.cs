using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMajorAssistance
{
    class CriteriaDetermination
    {
        //Criteria IT Governance
        public static Double criteriavalueitgov { get; set; }
        public static Double criteriabidangitgov { get; set; }
        public static Double criteriaminatitgov { get; set; }
        public static Double criteriakerjaitgov { get; set; }

        //Criteria Database
        public static Double criteriavaluedb { get; set; }
        public static Double criteriabidangdb { get; set; }
        public static Double criteriaminatdb { get; set; }
        public static Double criteriakerjadb { get; set; }

        //Criteria ERP
        public static Double criteriavalueerp { get; set; }
        public static Double criteriabidangerp { get; set; }
        public static Double criteriaminaterp { get; set; }
        public static Double criteriakerjaerp { get; set; }

        //Criteria Big Data
        public static Double criteriavaluebd { get; set; }
        public static Double criteriabidangbd { get; set; }
        public static Double criteriaminatbd { get; set; }
        public static Double criteriakerjabd { get; set; }

        //Nilai W
        public static Double Wnilai { get; set; }
        public static Double Wdiminati { get; set; }
        public static Double Wpeminatan{ get; set; }
        public static Double Wpekerjaan { get; set; }

        public void resetdata()
        {
            Wnilai = 0;
            Wdiminati = 0;
            Wpekerjaan = 0;
            Wpeminatan = 0;


            criteriavaluebd = 0;
            criteriavaluedb = 0;
            criteriavalueitgov = 0;
            criteriavalueerp = 0;

            criteriabidangbd = 0;
            criteriabidangdb = 0;
            criteriabidangitgov = 0;
            criteriabidangerp = 0;

            criteriaminatbd = 0;
            criteriaminatdb = 0;
            criteriaminaterp = 0;
            criteriaminatitgov = 0;

            criteriakerjabd = 0;
            criteriakerjadb = 0;
            criteriakerjaitgov = 0;
            criteriakerjaerp = 0;
        }


    }
}
