using System;
using System.Windows.Forms;

namespace SIMajorAssistance
{
    internal class WP
    {
        Double bnilai = 5;
        Double bdiminati = 4;
        Double bpeminatan = 3;
        Double bpekerjaan = 3;

        public void CountNilaiW()
        {
            CriteriaDetermination.Wnilai = bnilai / (bnilai + bdiminati + bpeminatan + bpekerjaan);
            CriteriaDetermination.Wdiminati = bdiminati / (bnilai + bdiminati + bpeminatan + bpekerjaan);
            CriteriaDetermination.Wpeminatan = bpeminatan / (bnilai + bdiminati + bpeminatan + bpekerjaan);
            CriteriaDetermination.Wpekerjaan = bpekerjaan / (bnilai + bdiminati + bpeminatan + bpekerjaan);
        }

        public void NilaiITGOV()
        {
            int countitgov = 0;
            Double totalitgov = 0;

            if (ValueGetSet.is100 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.is100;
                countitgov++;
            }

            if (ValueGetSet.is201 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.is201;
                countitgov++;
            }

            if (ValueGetSet.ea100 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.ea100;
                countitgov++;
            }

            if (ValueGetSet.em190 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.em190;
                countitgov++;
            }

            if (ValueGetSet.is251 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.is251;
                countitgov++;
            }

            if (ValueGetSet.ik402 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.ik402;
                countitgov++;
            }

            if (ValueGetSet.is588 != 0)
            {
                totalitgov = totalitgov + ValueGetSet.is588;
                countitgov++;
            }

            CriteriaDetermination.criteriavalueitgov = totalitgov / countitgov;
            totalitgov = 0;
            countitgov = 0;
        }

        public void NilaiDB()
        {
            int countdb = 0;
            Double totaldb = 0;

            if (ValueGetSet.is341 != 0)
            {
                totaldb = totaldb + ValueGetSet.is341;
                countdb++;
            }

            if (ValueGetSet.if100 != 0)
            {
                totaldb = totaldb + ValueGetSet.if100;
                countdb++;
            }

            if (ValueGetSet.is255 != 0)
            {
                totaldb = totaldb + ValueGetSet.is255;
                countdb++;
            }

            if (ValueGetSet.is534 != 0)
            {
                totaldb = totaldb + ValueGetSet.is534;
                countdb++;
            }

            if (ValueGetSet.is556 != 0)
            {
                totaldb = totaldb + ValueGetSet.is556;
                countdb++;
            }

            if (ValueGetSet.is431 != 0)
            {
                totaldb = totaldb + ValueGetSet.is431;
                countdb++;
            }

            CriteriaDetermination.criteriavaluedb = totaldb / countdb;
            totaldb = 0;
            countdb = 0;
        }

        public void NilaiERP()
        {
            int counterp = 0;
            Double totalerp = 0;

            if (ValueGetSet.is228 != 0)
            {
                totalerp = totalerp + ValueGetSet.is228;
                counterp++;
            }

            if (ValueGetSet.if100 != 0)
            {
                totalerp = totalerp + ValueGetSet.if100;
                counterp++;
            }

            if (ValueGetSet.is255 != 0)
            {
                totalerp = totalerp + ValueGetSet.is255;
                counterp++;
            }

            if (ValueGetSet.is201 != 0)
            {
                totalerp = totalerp + ValueGetSet.is201;
                counterp++;
            }

            if (ValueGetSet.is403 != 0)
            {
                totalerp = totalerp + ValueGetSet.is403;
                counterp++;
            }

            CriteriaDetermination.criteriavalueerp = totalerp / counterp;
            totalerp = 0;
            counterp = 0;
        }

        public void NilaiBD()
        {
            int countbd = 0;
            Double totalbd = 0;

            if (ValueGetSet.is240 != 0)
            {
                totalbd = totalbd + ValueGetSet.is240;
                countbd++;
            }

            if (ValueGetSet.is388 != 0)
            {
                totalbd = totalbd + ValueGetSet.is388;
                countbd++;
            }

            if (ValueGetSet.is545 != 0)
            {
                totalbd = totalbd + ValueGetSet.is545;
                countbd++;
            }

            if (ValueGetSet.is341 != 0)
            {
                totalbd = totalbd + ValueGetSet.is341;
                countbd++;
            }

            if (ValueGetSet.is255 != 0)
            {
                totalbd = totalbd + ValueGetSet.is255;
                countbd++;
            }

            CriteriaDetermination.criteriavaluebd = totalbd / countbd;
            totalbd = 0;
            totalbd = 0;
        }

        public void CountBidang()
        {
            if(ValueGetSet.AnalyticalState == true)
            {
                CriteriaDetermination.criteriabidangitgov = CriteriaDetermination.criteriabidangitgov + 1;
                CriteriaDetermination.criteriabidangdb = CriteriaDetermination.criteriabidangdb + 1;
                CriteriaDetermination.criteriabidangbd = CriteriaDetermination.criteriabidangbd + 1;
            }

            if(ValueGetSet.TechnicalState == true)
            {
                CriteriaDetermination.criteriabidangerp = CriteriaDetermination.criteriabidangerp + 1;
                CriteriaDetermination.criteriabidangdb = CriteriaDetermination.criteriabidangdb + 1;
                CriteriaDetermination.criteriabidangbd = CriteriaDetermination.criteriabidangbd + 1;
            }

            if(ValueGetSet.ManagerialState == true)
            {
                CriteriaDetermination.criteriabidangitgov = CriteriaDetermination.criteriabidangitgov + 1;
                CriteriaDetermination.criteriabidangerp = CriteriaDetermination.criteriabidangerp + 1;
            }
        }

        public void CountPeminatan()
        {
            /*CriteriaDetermination.criteriaminatitgov = 1;
            CriteriaDetermination.criteriaminaterp= 1;
            CriteriaDetermination.criteriaminatdb = 1;
            CriteriaDetermination.criteriaminatbd = 1;*/

            //Nilai Minat 1
            if (ValueGetSet.minat1.Equals("Big Data "))
            {
                CriteriaDetermination.criteriaminatitgov = 1;
                CriteriaDetermination.criteriaminatdb = 1;
                CriteriaDetermination.criteriaminaterp = 1;
                CriteriaDetermination.criteriaminatbd = 3;
            }
            else if (ValueGetSet.minat1.Equals("Database (Oracle)"))
            {
                CriteriaDetermination.criteriaminatitgov = 1;
                CriteriaDetermination.criteriaminatdb = 3;
                CriteriaDetermination.criteriaminaterp = 1;
                CriteriaDetermination.criteriaminatbd = 1;
            }
            else if (ValueGetSet.minat1.Equals("Enterprise Resource Planning (SAP ERP)"))
            {
                CriteriaDetermination.criteriaminatitgov = 1;
                CriteriaDetermination.criteriaminatdb = 1;
                CriteriaDetermination.criteriaminaterp = 3;
                CriteriaDetermination.criteriaminatbd = 1;
            }
            else if (ValueGetSet.minat1.Equals("IT Governance (COBIT, ITIL, TOGAF)"))
            {
                CriteriaDetermination.criteriaminatitgov = 3;
                CriteriaDetermination.criteriaminatdb = 1;
                CriteriaDetermination.criteriaminaterp = 1;
                CriteriaDetermination.criteriaminatbd = 1;
            }

            //Nilai Minat 2
            if (ValueGetSet.minat2.Equals("Big Data "))
            {
                CriteriaDetermination.criteriaminatbd = 2;
            }
            else if (ValueGetSet.minat2.Equals("Database (Oracle)"))
            {
                CriteriaDetermination.criteriaminatdb = 2;
            }
            else if (ValueGetSet.minat2.Equals("Enterprise Resource Planning (SAP ERP)"))
            {
                CriteriaDetermination.criteriaminaterp = 2;
            }
            else if (ValueGetSet.minat2.Equals("IT Governance (COBIT, ITIL, TOGAF)"))
            {
                CriteriaDetermination.criteriaminatitgov = 2;
            }
        }

        public void CountPekerjaan()
        {

            if(ValueGetSet.jobofchoice == "Developer")
            {
                CriteriaDetermination.criteriakerjadb = 3;
                CriteriaDetermination.criteriakerjaerp = 2;
                CriteriaDetermination.criteriakerjabd = 1;
                CriteriaDetermination.criteriakerjaitgov = 1;
            }
            else if(ValueGetSet.jobofchoice == "Database Administrator")
            {
                CriteriaDetermination.criteriakerjadb = 2;
                CriteriaDetermination.criteriakerjaerp = 1;
                CriteriaDetermination.criteriakerjabd = 1;
                CriteriaDetermination.criteriakerjaitgov = 1;
            }
            else if (ValueGetSet.jobofchoice == "Auditor / System Audit")
            {
                CriteriaDetermination.criteriakerjadb = 1;
                CriteriaDetermination.criteriakerjaerp = 2;
                CriteriaDetermination.criteriakerjabd = 1;
                CriteriaDetermination.criteriakerjaitgov = 3;
            }
            else if (ValueGetSet.jobofchoice == "Data Analyst")
            {
                CriteriaDetermination.criteriakerjadb = 1;
                CriteriaDetermination.criteriakerjaerp = 2;
                CriteriaDetermination.criteriakerjabd = 3;
                CriteriaDetermination.criteriakerjaitgov = 1;
            }
            else if (ValueGetSet.jobofchoice == "IT Consultant")
            {
                CriteriaDetermination.criteriakerjadb = 2;
                CriteriaDetermination.criteriakerjaerp = 2;
                CriteriaDetermination.criteriakerjabd = 1;
                CriteriaDetermination.criteriakerjaitgov = 2;
            }

        }

        public void CountVektorS()
        {
            Vektor.sitgov =
                (Math.Pow(CriteriaDetermination.criteriavalueitgov,CriteriaDetermination.Wnilai)) *
                (Math.Pow(CriteriaDetermination.criteriabidangitgov,CriteriaDetermination.Wdiminati)) *
                (Math.Pow(CriteriaDetermination.criteriaminatitgov,CriteriaDetermination.Wpeminatan)) *
                (Math.Pow(CriteriaDetermination.criteriakerjaitgov,CriteriaDetermination.Wpekerjaan));

            Vektor.sdb =
                (Math.Pow(CriteriaDetermination.criteriavaluedb,CriteriaDetermination.Wnilai)) *
                (Math.Pow(CriteriaDetermination.criteriabidangdb,CriteriaDetermination.Wdiminati)) *
                (Math.Pow(CriteriaDetermination.criteriaminatdb,CriteriaDetermination.Wpeminatan)) *
                (Math.Pow(CriteriaDetermination.criteriakerjadb,CriteriaDetermination.Wpekerjaan));

            Vektor.serp =
                (Math.Pow(CriteriaDetermination.criteriavalueerp,CriteriaDetermination.Wnilai)) *
                (Math.Pow(CriteriaDetermination.criteriabidangerp,CriteriaDetermination.Wdiminati)) *
                (Math.Pow(CriteriaDetermination.criteriaminaterp,CriteriaDetermination.Wpeminatan)) *
                (Math.Pow(CriteriaDetermination.criteriakerjaerp,CriteriaDetermination.Wpekerjaan));

            Vektor.sbd =
                (Math.Pow(CriteriaDetermination.criteriavaluebd, CriteriaDetermination.Wnilai)) *
                (Math.Pow(CriteriaDetermination.criteriabidangbd, CriteriaDetermination.Wdiminati)) *
                (Math.Pow(CriteriaDetermination.criteriaminatbd, CriteriaDetermination.Wpeminatan)) *
                (Math.Pow(CriteriaDetermination.criteriakerjabd, CriteriaDetermination.Wpekerjaan));
        }

        public void CountFinalVektor()
        {
            Vektor.vitgov = Vektor.sitgov / (Vektor.sitgov + Vektor.sdb + Vektor.serp + Vektor.sbd);
            Vektor.vdb = Vektor.sdb / (Vektor.sitgov + Vektor.sdb + Vektor.serp + Vektor.sbd);
            Vektor.verp = Vektor.serp / (Vektor.sitgov + Vektor.sdb + Vektor.serp + Vektor.sbd);
            Vektor.vbd = Vektor.sbd / (Vektor.sitgov + Vektor.sdb + Vektor.serp + Vektor.sbd);
        }

        public void SortFinalVektor()
        {
            string cobit = "IT Governance";
            string oracle = "Database";
            string bigdt = "Big Data";
            string sap = "Enterprise resource planning";

            double low1, low2, mid1, mid2, high1, high2;

            double a = Vektor.vitgov;
            double b = Vektor.vdb;
            double c = Vektor.vbd;
            double d = Vektor.verp;

            string rank1 =null, rank2 = null, rank3 = null, rank4 = null;
            string templow1, templow2, tempmid1, tempmid2, temphigh1, temphigh2;


            /*
            if (Vektor.vitgov > Vektor.vdb && Vektor.vitgov > Vektor.verp && Vektor.vitgov > Vektor.vbd)
            {
                rank1 = cobit;

                if(Vektor.vdb > Vektor.verp && Vektor.vdb > Vektor.vbd)
                {
                    rank2 = oracle;

                    if(Vektor.verp > Vektor.vbd)
                    {
                        rank3 = sap;
                        rank4 = bigdt;
                    }
                    else
                    {
                        rank3 = bigdt;
                        rank4 = sap;
                    }
                }
                else if (Vektor.vdb > Vektor.verp && Vektor.vdb < Vektor.vbd)
                {
                    rank2 = bigdt;
                    rank3 = oracle;
                    rank4 = sap;
                }
                else if (Vektor.vdb < Vektor.verp && Vektor.vdb > Vektor.vbd)
                {
                    rank2 = sap;
                    rank3 = oracle;
                    rank4 = bigdt;
                }
                else if (Vektor.vdb < Vektor.verp && Vektor.vdb < Vektor.vbd)
                {
                    rank4 = oracle;

                    if(Vektor.verp > Vektor.vbd)
                    {
                        rank2 = sap;
                        rank3 = bigdt;
                    }
                    else
                    {
                        rank2 = bigdt;
                        rank3 = sap;
                    }
                }
            }
            else if (Vektor.vitgov < Vektor.vdb && Vektor.vitgov > Vektor.verp && Vektor.vitgov > Vektor.vbd)
            {
                rank1 = oracle;
                rank2 = cobit;
                if (Vektor.verp > Vektor.vbd)
                {
                    rank3 = sap;
                    rank4 = bigdt;
                }
                else
                {
                    rank3 = bigdt;
                    rank4 = sap;
                }
            }
            else if (Vektor.vitgov < Vektor.vdb && Vektor.vitgov < Vektor.verp && Vektor.vitgov > Vektor.vbd)
            {
                rank3 = cobit;
                rank4 = bigdt;

                if(Vektor.vdb > Vektor.verp)
                {
                    rank1 = oracle;
                    rank2 = sap;
                }
                else
                {
                    rank1 = sap;
                    rank2 = oracle;
                }
            }
            else if (Vektor.vitgov < Vektor.vdb && Vektor.vitgov < Vektor.verp && Vektor.vitgov < Vektor.vbd)
            {
                rank4 = cobit;

                if (Vektor.vdb > Vektor.verp && Vektor.vdb > Vektor.vbd)
                {
                    rank1 = oracle;

                    if (Vektor.verp > Vektor.vbd)
                    {
                        rank2 = sap;
                        rank3 = bigdt;
                    }
                    else
                    {
                        rank2 = bigdt;
                        rank3 = sap;
                    }
                }
                else if (Vektor.vdb > Vektor.verp && Vektor.vdb < Vektor.vbd)
                {
                    rank1 = bigdt;
                    rank2 = oracle;
                    rank3 = sap;
                }
                else if (Vektor.vdb < Vektor.verp && Vektor.vdb > Vektor.vbd)
                {
                    rank1 = sap;
                    rank2 = oracle;
                    rank3 = bigdt;
                }
                else if (Vektor.vdb < Vektor.verp && Vektor.vdb < Vektor.vbd)
                {
                    rank3 = oracle;

                    if (Vektor.verp > Vektor.vbd)
                    {
                        rank1 = sap;
                        rank2 = bigdt;
                    }
                    else
                    {
                        rank1 = bigdt;
                        rank2 = sap;
                    }
                }
            }*/

            if (a < b){
                low1 = a;
                templow1 = cobit;
                high1 = b;
                temphigh1 = oracle;
            }
            else
            {
                low1 = b;
                templow1 = oracle;
                high1 = a;
                temphigh1 = cobit;
            }

            if (c < d)
            {
                low2 = c;
                templow2 = bigdt;
                high2 = d;
                temphigh2 = sap;
            }
            else
            {
                low2 = d;
                templow2 = sap;
                high2 = c;
                temphigh2 = bigdt;
            }

            if(low1 < low2)
            {
                if (templow1.Equals(cobit))
                {
                    rank4 = cobit;
                    tempmid1 = oracle;
                }
                else
                {
                    rank4 = oracle;
                    tempmid1 = cobit;
                }
                mid1 = low2;
            }
            else
            {
                if (templow2.Equals(bigdt))
                {
                    rank4 = bigdt;
                    tempmid1 = sap;
                }
                else
                {
                    rank4 = sap;
                    tempmid1 = bigdt;
                }
                mid1 = low1;
            }

            if (high1 > high2)
            {
                if (temphigh1.Equals(cobit))
                {
                    rank1 = cobit;
                    tempmid2 = oracle;
                }
                else
                {
                    rank1 = oracle;
                    tempmid2 = cobit;
                }
                mid2 = high2;
            }
            else
            {
                if (temphigh2.Equals(bigdt))
                {
                    rank1 = bigdt;
                    tempmid2 = sap;
                }
                else
                {
                    rank1 = sap;
                    tempmid2 = bigdt;
                }
                mid2 = high1;
            }

            if(mid1 > mid2)
            {
                if (tempmid1.Equals(cobit)){
                    rank2 = cobit;
                }
                else if (tempmid1.Equals(oracle))
                {
                    rank2 = oracle;
                }
                else if (tempmid1.Equals(bigdt))
                {
                    rank2 = bigdt;
                }
                else
                {
                    rank2 = sap;
                }

                if (tempmid2.Equals(cobit))
                {
                    rank3 = cobit;
                }
                else if (tempmid2.Equals(oracle))
                {
                    rank3 = oracle;
                }
                else if (tempmid2.Equals(bigdt))
                {
                    rank3 = bigdt;
                }
                else
                {
                    rank3 = sap;
                }
            }
            else
            {
                if (tempmid1.Equals(cobit))
                {
                    rank3 = cobit;
                }
                else if (tempmid1.Equals(oracle))
                {
                    rank3 = oracle;
                }
                else if (tempmid1.Equals(bigdt))
                {
                    rank3 = bigdt;
                }
                else
                {
                    rank3 = sap;
                }

                if (tempmid2.Equals(cobit))
                {
                    rank2 = cobit;
                }
                else if (tempmid2.Equals(oracle))
                {
                    rank2 = oracle;
                }
                else if (tempmid2.Equals(bigdt))
                {
                    rank2 = bigdt;
                }
                else
                {
                    rank2 = sap;
                }
            }


            Vektor.first = rank1;
            Vektor.second = rank2;
            Vektor.third = rank3;
            Vektor.last = rank4;
        }
    }
}