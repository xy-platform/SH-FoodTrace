﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodTrace.Model.DtoModel
{
    public class KillBatchDetailDto
    {
        public int DetailID { get; set; }
        public int? KillBatchID { get; set; }

        public string KillBatchNO { get; set; }
        public int CultivationID { get; set; }

        public int? BreedID { get; set; }

        public string BreedName { get; set; }
        public int? AreaID { get; set; }
        public string AreaName { get; set; }
        public int? HomeID { get; set; }

        public string HomeName { get; set; }
        public string CultivationEpc { get; set; }
        public string Remark { get; set; }
        public bool? IsLocked { get; set; }
        public bool? IsShow { get; set; }
    }
}
