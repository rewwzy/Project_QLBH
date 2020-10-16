﻿using DAL;
using DTO;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public class BUS_NHANVIEN
    {
        
     
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encrypdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypdata.Append(encrypt[i].ToString("x2"));
            }
            return encrypdata.ToString();
        }
        public static bool DangNhap(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.DangNhap(nv);
        }
        public static bool QuenMatKhau(string email)
        {
            return DAL_NHANVIEN.QuenMatKhau(email);
        }
        public static bool TaoMatKhauMoi(string email, string newPassword)
        {
            return DAL_NHANVIEN.TaoMatKhauMoi(email, newPassword);
        }
        public static DataTable LayVaiTroNV(string email)
        {
            return DAL_NHANVIEN.VaiTroNhanVien(email);
        }
        public static bool DoimatKhau(string email,string matKhauCu,string matKhauMoi)
        {
            return DAL_NHANVIEN.UpdateMatKhau(email, matKhauCu, matKhauMoi);
        }
        public static DataTable getNhanVien()
        {
            return DAL_NHANVIEN.getNhanVien();
        }
        public static bool insertNhanVien(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.InsertNhanVien(nv);
        }
        
        public static bool updateNhanVien(DTO_NHANVIEN nv)
        {
            return DAL_NHANVIEN.UpdateNhanVien(nv);
        }
        public static bool deleteNhanVien(string tenDangNhap)
        {
            return DAL_NHANVIEN.DeleteNhanVien(tenDangNhap);
        }
        public static DataTable SearchNhanVien(string tenNhanVien)
        {
            return DAL_NHANVIEN.SearchNhanVien(tenNhanVien);
        }
    }
}
