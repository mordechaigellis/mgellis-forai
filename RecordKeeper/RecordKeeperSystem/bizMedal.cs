﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeperSystem
{
    public class bizMedal : bizObject<bizMedal>
    {
        public int MedalId { get; set; }
        public string MedalName { get; set; } = "";

    }
}
