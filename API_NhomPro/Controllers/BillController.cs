﻿using AppData.IRepositories;
using AppData.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nhom1_Pro.Models;
using System.Linq;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IAllRepo<Bill> allRepo;
        DBContextModel dbContextModel = new DBContextModel();
        DbSet<Bill> bills;
        public BillController()
        {
            bills = dbContextModel.Bills;
            allRepo = new AllRepo<Bill>(dbContextModel, bills);
        }
        // GET: api/<BillController>
        [HttpGet("{id}")]
        public Bill Get(Guid id)
        {
            return allRepo.GetAll().First(x => x.Id == id);
        }
        [HttpGet]
        public IEnumerable<Bill> Get()
        {
            return allRepo.GetAll();
        }
        // GET api/<BillController>/5
        [HttpPost]
        public bool CreateBill(Guid id, Guid idUser, Guid idVoucher, DateTime ngayTao, DateTime ngayThanhToan, DateTime ngayShip, DateTime ngayNhan,
            string tenNguoiNhan, string diaChi, string sdt, int tongTien, int soTienGiam, int tienShip, string moTa, int trangThai)
        {
            string ma;
            if(allRepo.GetAll().Count()==null)
            {
                ma = "Bill1";
            }
            else {
                ma = "Bill"+ (allRepo.GetAll().Count()+1);
            }
            Bill bill = new Bill()
            {
                Id = id,
                IdUser = idUser,
                IdVoucher = idVoucher,
                Ma = ma,
                NgayTao = ngayTao,
                NgayThanhToan = ngayThanhToan,
                NgayShip = ngayShip,
                NgayNhan = ngayNhan,
                TenNguoiNhan = tenNguoiNhan,
                DiaChi = diaChi,
                Sdt = sdt,
                TongTien = tongTien,
                SoTienGiam = soTienGiam,
                TienShip = tienShip,
                MoTa = moTa,
                TrangThai = trangThai
            };
            return allRepo.AddItem(bill);
        }

        // POST api/<BillController>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            var bill = allRepo.GetAll().First(x => x.Id == id);
            return allRepo.RemoveItem(bill);
        }

        // PUT api/<BillController>/5
        [HttpPut("{id}")]
        public bool Put(Guid id, Guid idUser, Guid idVoucher, string ma, DateTime ngayTao, DateTime ngayThanhToan, DateTime ngayShip, DateTime ngayNhan,
            string tenNguoiNhan, string diaChi, string sdt, int tongTien, int soTienGiam, int tienShip, string moTa, int trangThai)
        {
            var bill = allRepo.GetAll().First(p => p.Id == id);

            bill.IdUser = idUser;
            bill.IdVoucher = idVoucher;
            bill.Ma = ma;
            bill.NgayTao = ngayTao;
            bill.NgayThanhToan = ngayThanhToan;
            bill.NgayShip = ngayShip;
            bill.NgayNhan = ngayNhan;
            bill.TenNguoiNhan = tenNguoiNhan;
            bill.DiaChi = diaChi;
            bill.Sdt = sdt;
            bill.TongTien = tongTien;
            bill.SoTienGiam = soTienGiam;
            bill.TienShip = tienShip;
            bill.MoTa = moTa;
            bill.TrangThai = trangThai;
            return allRepo.EditItem(bill);
        }
    }
}
