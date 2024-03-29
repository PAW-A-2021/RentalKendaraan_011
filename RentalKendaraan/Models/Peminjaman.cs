﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCostumer { get; set; }
        public int? IdJaminan { get; set; }
        public int? Biaya { get; set; }

        public virtual Customer IdCostumerNavigation { get; set; }
        public virtual Jaminan IdJaminanNavigation { get; set; }
        public virtual Kendaraan IdKendaraanNavigation { get; set; }
    }
}
