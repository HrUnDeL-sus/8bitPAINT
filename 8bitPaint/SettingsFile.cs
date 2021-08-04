﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8bitPaint
{
    [Serializable]
    public class SettingsFile
    {
        public string name { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string unique_id { get; set; }
        public byte[] picture { get; set; }

        
    }
}
