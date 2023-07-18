﻿using System;
using System.Collections.Generic;

namespace _1_DAL.Models
{
    public partial class SeatDetail
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public long PlaneTypeId { get; set; }
        public string SeatCode { get; set; } = null!;
        public int? Status { get; set; }

        public virtual Class Class { get; set; } = null!;
        public virtual PlaneType PlaneType { get; set; } = null!;
    }
}
