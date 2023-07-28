using DevExpress.XtraEditors;
using eGhis.Controls;
using EunJinBookManager.Presenter;
using EunJinBookManagerEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EunJinBookManager
{
    public partial class Book : DevExpress.XtraEditors.XtraForm
    {
        BookPresenter _presenter = null;

        public Book()
        {
            InitializeComponent();

            _presenter = new BookPresenter();

            this.Shown += Book_Shown;

            BtnReset.Click += BtnReset_Click;
            BtnSave.Click += BtnSave_Click;
            BtnDelete.Click += BtnDelete_Click;
            BtnClose.Click += BtnClose_Click;
        }

        //초기화
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBId.Text = "";
            TxtBNm.Text = "";
            TxtBAnthor.Text = "";
            TxtBCost.Text = "";

            Search();
        }

        //저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool isSucces = Save();

            if (isSucces)
            {
                EghisMessageBox.Show("저장 완료");
                Search();
            }
            else
            {
                EghisMessageBox.Show("저장 실패");
                return;
            }
        }
        private bool Save()
        {
            BooksEntity book = new BooksEntity();
            book.bId = Convert.ToInt32(TxtBId.Text);
            book.bNm = TxtBNm.Text;
            book.bAnthor = TxtBAnthor.Text;
            book.bCost = Convert.ToInt32(TxtBCost.Text);

            return _presenter.Save(book);
        }

        //삭제
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool isSucces = Delete();

            if (isSucces)
            {
                EghisMessageBox.Show("삭제 완료");
                Search();
            }
            else
            {
                EghisMessageBox.Show("삭제 실패");
                return;
            }
        }

        private bool Delete()
        {
            BooksEntity book = new BooksEntity();
            book.bId = Convert.ToInt32(TxtBId.Text);

            return _presenter.Delete(book);
        }

        //닫기
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //조회
        private void Book_Shown(object sender, EventArgs e)
        {
            SetGridHeader();
            Search();
        }
        private void SetGridHeader()
        {
            GridSearch.AddColumn("bId", "도서ID", 80);
            GridSearch.AddColumn("bNm", "도서제목", 180);
            GridSearch.AddColumn("bAnthor", "도서저자", 80);
            GridSearch.AddColumn("bCost", "도서가격", 100);
        }
        private void Search()
        {
            List<BooksEntity> list = _presenter.Search();
            GridSearch.DataSource = list;
        }
    }
}