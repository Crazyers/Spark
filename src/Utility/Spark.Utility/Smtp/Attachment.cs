﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spark.Utility.Smtp
{
    public class Attachment
    {
        public string FileName { get; set; }

        public byte[] File { get; set; }
    }
}