﻿using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DELFI_WHM.NET.CauHinh
{
    public partial class frmCauHinhSyncDuLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmCauHinhSyncDuLieu()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblConfigLinkSync.Where(c => c.Value == txtGiaTri.Text).FirstOrDefault();
                if (data != null)
                {
                    XtraMessageBox.Show("Value đã tồn tại, vui lòng nhập nội dung khác.", "Thông báo");
                }
                else
                {
                    tblConfigLinkSync cf = new tblConfigLinkSync();
                    cf.Value = txtGiaTri.uText.Trim();
                    cf.Name = txtTen.uText.Trim();
                    cf.Description = txtGhiChu.uText.Trim();
                    cf.CreateDate = DateTime.Now;
                    cf.UserCreate = Properties.Settings.Default.USER_NAME;
                    db.tblConfigLinkSync.Add(cf);

                    if (db.SaveChanges() > 0)
                    {
                        XtraMessageBox.Show("Thêm thông tin thành công.", "Thông báo");
                        LoadData();
                        txtGhiChu.uText = "";
                        txtTen.uText = "";
                        txtGiaTri.uText = "";
                    }
                }
            }
        }

        /// <summary>
        /// hiển thị danh sách link cấu hình. Sắp xếp thông tin mới lên trên cùng
        /// </summary>
        void LoadData()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var data = db.tblConfigLinkSync.OrderByDescending(c => c.CreateDate).ToList();
                if (data != null)
                {
                    gridDanhSach.DataSource = data;
                }
            }
        }

        private void frmCauHinhSyncDuLieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void gridView1_CustomDrawRowIndicator_1(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }
    }
}
