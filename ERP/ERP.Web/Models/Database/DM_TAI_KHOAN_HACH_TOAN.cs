
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ERP.Web.Models.Database
{

using System;
    using System.Collections.Generic;
    
public partial class DM_TAI_KHOAN_HACH_TOAN
{

    public DM_TAI_KHOAN_HACH_TOAN()
    {

        this.DM_HANG_HOA = new HashSet<DM_HANG_HOA>();

        this.DM_HANG_HOA1 = new HashSet<DM_HANG_HOA>();

        this.DM_HANG_HOA2 = new HashSet<DM_HANG_HOA>();

        this.DM_TAI_KHOAN_HACH_TOAN1 = new HashSet<DM_TAI_KHOAN_HACH_TOAN>();

        this.KHO_CT_NHAP_KHO = new HashSet<KHO_CT_NHAP_KHO>();

        this.KHO_CT_NHAP_KHO1 = new HashSet<KHO_CT_NHAP_KHO>();

        this.KHO_CT_NHAP_KHO2 = new HashSet<KHO_CT_NHAP_KHO>();

        this.KHO_CT_XUAT_KHO = new HashSet<KHO_CT_XUAT_KHO>();

        this.KHO_CT_XUAT_KHO1 = new HashSet<KHO_CT_XUAT_KHO>();

        this.KHO_CT_XUAT_KHO2 = new HashSet<KHO_CT_XUAT_KHO>();

        this.MUA_HANG_CT_HDMH = new HashSet<MUA_HANG_CT_HDMH>();

        this.MUA_HANG_CT_HDMH1 = new HashSet<MUA_HANG_CT_HDMH>();

        this.MUA_HANG_CT_HDMH2 = new HashSet<MUA_HANG_CT_HDMH>();

        this.NGAN_HANG_CT_NTTK = new HashSet<NGAN_HANG_CT_NTTK>();

        this.NGAN_HANG_CHUYEN_TIEN_NOI_BO = new HashSet<NGAN_HANG_CHUYEN_TIEN_NOI_BO>();

        this.NGAN_HANG_CT_UNC = new HashSet<NGAN_HANG_CT_UNC>();

        this.NGAN_HANG_CT_NTTK1 = new HashSet<NGAN_HANG_CT_NTTK>();

        this.NGAN_HANG_CHUYEN_TIEN_NOI_BO1 = new HashSet<NGAN_HANG_CHUYEN_TIEN_NOI_BO>();

        this.NGAN_HANG_CT_UNC1 = new HashSet<NGAN_HANG_CT_UNC>();

        this.QUY_CT_PHIEU_THU = new HashSet<QUY_CT_PHIEU_THU>();

        this.QUY_CT_PHIEU_CHI = new HashSet<QUY_CT_PHIEU_CHI>();

        this.QUY_CT_PHIEU_THU1 = new HashSet<QUY_CT_PHIEU_THU>();

        this.QUY_CT_PHIEU_CHI1 = new HashSet<QUY_CT_PHIEU_CHI>();

        this.QUY_CT_PHIEU_CHI2 = new HashSet<QUY_CT_PHIEU_CHI>();

    }


    public string SO_TK { get; set; }

    public string TEN_TK { get; set; }

    public string TINH_CHAT { get; set; }

    public string TEN_TA { get; set; }

    public string TK_CAP_CHA { get; set; }

    public string DIEN_GIAI { get; set; }



    public virtual ICollection<DM_HANG_HOA> DM_HANG_HOA { get; set; }

    public virtual ICollection<DM_HANG_HOA> DM_HANG_HOA1 { get; set; }

    public virtual ICollection<DM_HANG_HOA> DM_HANG_HOA2 { get; set; }

    public virtual ICollection<DM_TAI_KHOAN_HACH_TOAN> DM_TAI_KHOAN_HACH_TOAN1 { get; set; }

    public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN2 { get; set; }

    public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO { get; set; }

    public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO1 { get; set; }

    public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO2 { get; set; }

    public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO { get; set; }

    public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO1 { get; set; }

    public virtual ICollection<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO2 { get; set; }

    public virtual ICollection<MUA_HANG_CT_HDMH> MUA_HANG_CT_HDMH { get; set; }

    public virtual ICollection<MUA_HANG_CT_HDMH> MUA_HANG_CT_HDMH1 { get; set; }

    public virtual ICollection<MUA_HANG_CT_HDMH> MUA_HANG_CT_HDMH2 { get; set; }

    public virtual ICollection<NGAN_HANG_CT_NTTK> NGAN_HANG_CT_NTTK { get; set; }

    public virtual ICollection<NGAN_HANG_CHUYEN_TIEN_NOI_BO> NGAN_HANG_CHUYEN_TIEN_NOI_BO { get; set; }

    public virtual ICollection<NGAN_HANG_CT_UNC> NGAN_HANG_CT_UNC { get; set; }

    public virtual ICollection<NGAN_HANG_CT_NTTK> NGAN_HANG_CT_NTTK1 { get; set; }

    public virtual ICollection<NGAN_HANG_CHUYEN_TIEN_NOI_BO> NGAN_HANG_CHUYEN_TIEN_NOI_BO1 { get; set; }

    public virtual ICollection<NGAN_HANG_CT_UNC> NGAN_HANG_CT_UNC1 { get; set; }

    public virtual ICollection<QUY_CT_PHIEU_THU> QUY_CT_PHIEU_THU { get; set; }

    public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI { get; set; }

    public virtual ICollection<QUY_CT_PHIEU_THU> QUY_CT_PHIEU_THU1 { get; set; }

    public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI1 { get; set; }

    public virtual ICollection<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI2 { get; set; }

}

}
