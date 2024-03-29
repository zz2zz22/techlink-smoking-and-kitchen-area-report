﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSmokingData_Techlink
{
    public class SaveVariables
    {
        public static String TimeIn { get; set; }
        public static String TimeOut { get; set; }
        public static String ID { get; set; }
        public static String Desc { get; set; }
        public static String Dept { get; set; }
        public static String DeptName { get; set; }
        public static String TempID { get; set; }

        public static String TempBreakID1 { get; set; }
        public static String TempBreakID2 { get; set; }
        public static String TempBreakID3 { get; set; }
        public static String TempBreakID4 { get; set; }

        public static void ResetVariables()
        {
            TimeIn = null;
            TimeOut = null;
            ID = null;
            Desc = null;
            TempID = null;
        }
        public static void ResetDept()
        {
            Dept = null;
            DeptName = null;
        }
        public static void ResetTempValue()
        {
            TempBreakID1 = null;
            TempBreakID2 = null;
            TempBreakID3 = null;
            TempBreakID4 = null;
        }
    }
}
