﻿using System;
using System.Collections.Generic;

namespace Awm.awmDb
{
    public partial class Material
    {
        public int MaterialId { get; set; }
        public DateTime? IntakeDate { get; set; }
        public DateTime? BestBeforeDate { get; set; }
        public string Gnr { get; set; }
    }
}
