﻿using DevExpress.DashboardCommon.DataProcessing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraLayout.Resizing;
using eGhis.Controls;
using EunJinBookManager.Presenter;
using EunJinBookManagerEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace EunJinBookManager
{
    public partial class Customers : DevExpress.XtraEditors.XtraForm
    {
        CustomersPresenter _presenter = null;

        public Customers()
        {
            InitializeComponent();

            _presenter = new CustomersPresenter();

            this.Shown += Customers_Shown;

            BtnReset.Click += BtnReset_Click;
            BtnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;

            GridSearch.CellLeftDoubleClick += GridSearch_CellLeftDoubleClick;
        }

        //초기화
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DataReset();
            Search();
        }

        private void DataReset()
        {
            TxtCId.ReadOnly = true;
            TxtCId.Text = "";
            F.Checked = false;
            M.Checked = false;
            CbxJob.SelectedText = string.Empty;
            TxtCNm.Text = "";
            TxtPhone.Text = "";
            TxtAddr.Text = "";
        }

        //저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isSucces = Save();

            if(isSucces)
            {
                EghisMessageBox.Show("고객이 등록되었습니다.");
                DataReset();
                Search();
            }
            else
            {
                EghisMessageBox.Show("고객을 등록할 수 없습니다.");
                return;
            }
        }

        private bool Save()
        {
            CustomersEntity customers = new CustomersEntity();
            customers.sex = M.Checked ? "M" : "F";
            customers.cNm = TxtCNm.Text;

            string selectedValue = CbxJob.SelectedItem?.ToString();
            string result;

            if (selectedValue == "직장인")
                result = "O";
            else if (selectedValue == "무직")
                result = "I";
            else if (selectedValue == "학생")
                result = "S";
            else
                result = "N/A";

            customers.job = result;
            customers.phone = TxtPhone.Text.Replace("-", "");
            customers.addr = TxtAddr.Text;

            return _presenter.Save(customers);
        }

        //삭제
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool isSucces = Delete();

            if(isSucces)
            {
                EghisMessageBox.Show("고객이 삭제되었습니다.");

                Search();
                DataReset();
            }
            else
            {
                EghisMessageBox.Show("고객을 삭제할 수 없습니다.");
                return;
            }
        }

        private bool Delete()
        {
            CustomersEntity customers = new CustomersEntity();
            customers.cId = Convert.ToInt32(TxtCId.Text);

            return _presenter.Delete(customers);
        }

        private void GridSearch_CellLeftDoubleClick(object sender, eGhis.CustomEventArgs.CellRowClickEventArgs e)
        {
            CustomersEntity customers = e.Row as CustomersEntity;
            TxtCId.Text = customers.cId.ToString();
           
            if (customers.sex.Equals("M"))
            {
                M.Checked = true;
            }
            else if (customers.sex.Equals("F"))
            {
                F.Checked = true;
            }

            TxtCNm.Text = customers.cNm.ToString();
            CbxJob.Text = customers.job.ToString();
            TxtAddr.Text = customers.addr.ToString();
            TxtPhone.Text = customers.phone.ToString();

            if (customers.job == "O")
                CbxJob.SelectedIndex = 1;
            else if (customers.job == "I")
                CbxJob.SelectedIndex = 2;
            else if (customers.job == "S")
                CbxJob.SelectedIndex = 0;
            else
                CbxJob.SelectedText = string.Empty;
        }

        //닫기
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //조회
        private void Customers_Shown(object sender, EventArgs e)
        {
            TxtCId.ReadOnly = true;
            string[] jobList = { "학생", "직장인", "무직" };
            CbxJob.DataSource = jobList;
            //CbxJob.AddDataRow("");

            SetGridHeader();
            Search();
        }

        private void SetGridHeader()
        {
            GridSearch.AddColumn("cId", "고객ID", 80);
            GridSearch.AddColumn("sexNm", "성별", 50);
            GridSearch.AddColumn("cNm", "고객명", 100);
            GridSearch.AddColumn("jobNm", "직업", 100);
            GridSearch.AddColumn("phone", "전화번호", 150);
            GridSearch.AddColumn("addr", "주소", 200);
        }
        
        private void Search()
        {
            TxtCId.ReadOnly = true;
            List<CustomersEntity> list = _presenter.Search();
            GridSearch.DataSource = list;
        }
    }
}