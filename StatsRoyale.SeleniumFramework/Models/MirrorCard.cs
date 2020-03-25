﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsRoyale.SeleniumFramework.Models
{
    public class MirrorCard : Card
    {
        public override string Name { get; set; } = "Mirror";
        public override int Cost { get; set; } = 1;
        public override string RarityStatus { get; set; } = "Epic";

        public override string Category { get; set; } = "Spell";

        public override string Arena { get; set; } = "Arena 12";
    }
}
