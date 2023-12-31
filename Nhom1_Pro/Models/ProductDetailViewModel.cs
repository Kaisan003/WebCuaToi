﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class ProductDetailViewModel
    {
        public Guid? IdProduct { get; set; }
        public Guid? IdColor { get; set; }
        public Guid? IdSize { get; set; }
        public Guid? IdTypeProduct { get; set; }
        public Guid? IdMaterial { get; set; }
        public string? BaoHanh { get; set; }
        public string? MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        public decimal? GiaNhap { get; set; }
        public decimal? GiaBan { get; set; }
        public int? TrangThai { get; set; }
    }
}
