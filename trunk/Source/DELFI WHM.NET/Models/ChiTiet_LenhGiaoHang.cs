//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DELFI_WHM.NET.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTiet_LenhGiaoHang
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> PostingDate { get; set; }
        public string SaleOrderCalNo { get; set; }
        public string SaleContractNo { get; set; }
        public string ItemNo { get; set; }
        public string CertificationCode { get; set; }
        public string LocationCode { get; set; }
        public string BinCode { get; set; }
        public Nullable<decimal> PackingUnit { get; set; }
        public string PackingUnitName { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string Status { get; set; }
        public string LineNo { get; set; }
        public string Lot { get; set; }
        public Nullable<decimal> QtyPicked { get; set; }
        public string UserName { get; set; }
    }
}