﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA;

namespace IndigenousTribes
{
    public class Program
    {
        [MainMethod()]
        static public void Main()
        {

            FISCA.Presentation.RibbonBarItem report = FISCA.Presentation.MotherForm.RibbonBarItems["學生", "資料統計"];
            report["報表"]["公務統計相關報表"]["原住民族別統計"].Click += delegate
            {
                Form2 f = new Form2();
                f.ShowDialog();
            };



        }
    }
}
