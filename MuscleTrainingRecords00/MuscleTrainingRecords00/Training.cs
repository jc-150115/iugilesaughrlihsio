﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuscleTrainingRecords00
{
    public class Training
    {

        public string Menu { get; set; }
        public string Load { get; set; }
        public string parts { get; set; }

        public string getMenu()
        {
            return Menu;
        }


        public override string ToString()
        {
            return Menu + "                                                                                負荷度：" + Load;
        }

    }
}
