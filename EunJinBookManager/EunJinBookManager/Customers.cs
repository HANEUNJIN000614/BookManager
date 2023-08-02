using DevExpress.DashboardCommon.DataProcessing;
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

            this.Load += Customers_Load;

            BtnReset.Click += BtnReset_Click;
            BtnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;

            GridSearch.CellLeftClick += GridSearch_CellLeftClick;
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
            return;
        }

        private bool Save()
        {
            CustomersEntity customers = new CustomersEntity();

            if (!ValidateInput(customers))
            {
                return false;
            }

            return _presenter.Save(customers);
        }

        private bool ValidateInput(CustomersEntity customers)
        {
            // 고객명 유효성 검증
            if (string.IsNullOrWhiteSpace(TxtCNm.Text))
            {
                EghisMessageBox.Show("고객명을 입력해주세요.");
                TxtCNm.Focus();
                return false;
            }

            // 성별 유효성 검증
            if (!M.Checked && !F.Checked)
            {
                EghisMessageBox.Show("성별을 선택해주세요.");
                return false;
            }

            customers.sex = M.Checked ? "M" : "F";
            customers.cNm = TxtCNm.Text;

            // 직업 유효성 검증
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

            // 직업 유효성 검증
            if (result == "N/A")
            {
                EghisMessageBox.Show("직업을 선택해주세요.");
                return false;
            }

            customers.job = result;

            // 전화번호 유효성 검증
            if (string.IsNullOrWhiteSpace(TxtPhone.Text) || !long.TryParse(TxtPhone.Text.Replace("-", ""), out _))
            {
                EghisMessageBox.Show("유효한 전화번호를 입력해주세요.");
                TxtPhone.Focus();
                return false;
            }

            customers.phone = TxtPhone.Text.Replace("-", "");

            // 주소 유효성 검증
            if (string.IsNullOrWhiteSpace(TxtAddr.Text))
            {
                EghisMessageBox.Show("주소를 입력해주세요.");
                TxtAddr.Focus();
                return false;
            }

            customers.addr = TxtAddr.Text;

            return true;
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

        private void GridSearch_CellLeftClick(object sender, eGhis.CustomEventArgs.CellRowClickEventArgs e)
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
        private void Customers_Load(object sender, EventArgs e)
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