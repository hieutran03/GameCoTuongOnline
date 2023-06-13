using CoTuongLAN.ProgramConfig;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoTuongLAN.CoTuong
{
    public class QuanMa : QuanCo
    {
        public QuanMa() { }

        public QuanMa(Point toaDoBanDau)
        {
            ToaDo = toaDoBanDau;
            DanhSachDiemDich = new List<Point>();
            if (BanCo.PheTa == 2)
                Mau = ThongSoPheDo.MauQuanCo(toaDoBanDau);
            else if (BanCo.PheTa == 1)
                Mau = ThongSoPheXanh.MauQuanCo(toaDoBanDau);
            BanCo.Alive_QuanCo.Add(this);
        }
        
        public override void TinhNuocDi()
        {
            Point diemCan;
            Point toaDoMucTieu;
            QuanCo quanCoMucTieu;

                diemCan = new Point(ToaDo.X - 1, ToaDo.Y);

                toaDoMucTieu = new Point(ToaDo.X - 2, ToaDo.Y - 1);
                if (NamTrongBanCo(toaDoMucTieu) &&!BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                toaDoMucTieu = new Point(ToaDo.X - 2, ToaDo.Y + 1);
                if (NamTrongBanCo(toaDoMucTieu)&&!BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                diemCan = new Point(ToaDo.X + 1, ToaDo.Y);

                toaDoMucTieu = new Point(ToaDo.X + 2, ToaDo.Y - 1);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                toaDoMucTieu = new Point(ToaDo.X + 2, ToaDo.Y + 1);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                diemCan = new Point(ToaDo.X, ToaDo.Y - 1);
                toaDoMucTieu = new Point(ToaDo.X - 1, ToaDo.Y - 2);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                toaDoMucTieu = new Point(ToaDo.X + 1, ToaDo.Y - 2);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
            //}

            // Xét điểm cản (ToaDo.X, ToaDo.Y + 1)
                diemCan = new Point(ToaDo.X, ToaDo.Y + 1);
            //if (NamTrongBanCo(diemCan) && !BanCo.CoQuanCoTaiDay(diemCan))
            //{
                toaDoMucTieu = new Point(ToaDo.X - 1, ToaDo.Y + 2);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
                toaDoMucTieu = new Point(ToaDo.X + 1, ToaDo.Y + 2);
                if (NamTrongBanCo(toaDoMucTieu) && !BanCo.CoQuanCoTaiDay(diemCan))
                {
                    if (!BanCo.CoQuanCoTaiDay(toaDoMucTieu))
                    {
                        DanhSachDiemDich.Add(toaDoMucTieu);
                    }
                    else
                    {
                        quanCoMucTieu = BanCo.GetQuanCo(toaDoMucTieu);
                        if (quanCoMucTieu.Mau != this.Mau)
                        {
                            DanhSachDiemDich.Add(toaDoMucTieu);
                        }
                    }
                }
            //}
        }
    }
}