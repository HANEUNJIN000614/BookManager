namespace EunJinBookManager
{
    partial class Book
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.eghisGroupBox1 = new eGhis.Controls.EghisGroupBox();
            this.GridSearch = new eGhis.Controls.EghisDataGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.eghisLayoutControl1 = new eGhis.Controls.EghisLayoutControl();
            this.TxtBCost = new eGhis.Controls.EghisTextBox();
            this.TxtBAnthor = new eGhis.Controls.EghisTextBox();
            this.TxtBNm = new eGhis.Controls.EghisTextBox();
            this.TxtBId = new eGhis.Controls.EghisTextBox();
            this.Root = new eGhis.Controls.EghisLayoutGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.eghisTablePanel1 = new eGhis.Controls.EghisTablePanel();
            this.BtnClose = new eGhis.Controls.EghisButton();
            this.BtnDelete = new eGhis.Controls.EghisButton();
            this.BtnSave = new eGhis.Controls.EghisButton();
            this.BtnReset = new eGhis.Controls.EghisButton();
            ((System.ComponentModel.ISupportInitialize)(this.eghisGroupBox1)).BeginInit();
            this.eghisGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eghisLayoutControl1)).BeginInit();
            this.eghisLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBAnthor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBNm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eghisTablePanel1)).BeginInit();
            this.eghisTablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eghisGroupBox1
            // 
            this.eghisGroupBox1.AutoFontSizeChange = true;
            this.eghisGroupBox1.Controls.Add(this.GridSearch);
            this.eghisGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eghisGroupBox1.Location = new System.Drawing.Point(10, 135);
            this.eghisGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.eghisGroupBox1.Name = "eghisGroupBox1";
            this.eghisGroupBox1.Size = new System.Drawing.Size(578, 223);
            this.eghisGroupBox1.TabIndex = 0;
            this.eghisGroupBox1.Text = "도서 목록 현황";
            // 
            // GridSearch
            // 
            this.GridSearch.AutoFontSizeChange = true;
            this.GridSearch.AutoSaveLoadLayout = false;
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.GridRowFont = new System.Drawing.Font("Tahoma", 9F);
            this.GridSearch.GridRowHeaderFont = new System.Drawing.Font("Tahoma", 9F);
            this.GridSearch.GridSelectionType = eGhis.Controls.GridSelectionType.Row;
            this.GridSearch.GroupPanelText = " 항목을 끌어 그룹을 설정할 수 있습니다.";
            this.GridSearch.Location = new System.Drawing.Point(2, 23);
            this.GridSearch.MainView = this.gridView1;
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.NewRowType = eGhis.Controls.NewRowType.None;
            this.GridSearch.ShowColumnHeader = true;
            this.GridSearch.ShowGroupingPanel = false;
            this.GridSearch.Size = new System.Drawing.Size(574, 198);
            this.GridSearch.TabIndex = 0;
            this.GridSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridSearch;
            this.gridView1.GroupPanelText = " 항목을 끌어 그룹을 설정할 수 있습니다.";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GridSearch;
            this.gridView2.GroupPanelText = " 항목을 끌어 그룹을 설정할 수 있습니다.";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView2.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // eghisLayoutControl1
            // 
            this.eghisLayoutControl1.AutoFontSizeChange = true;
            this.eghisLayoutControl1.AutoSize = true;
            this.eghisLayoutControl1.Controls.Add(this.TxtBCost);
            this.eghisLayoutControl1.Controls.Add(this.TxtBAnthor);
            this.eghisLayoutControl1.Controls.Add(this.TxtBNm);
            this.eghisLayoutControl1.Controls.Add(this.TxtBId);
            this.eghisLayoutControl1.Location = new System.Drawing.Point(10, 21);
            this.eghisLayoutControl1.Name = "eghisLayoutControl1";
            this.eghisLayoutControl1.Root = this.Root;
            this.eghisLayoutControl1.Size = new System.Drawing.Size(266, 96);
            this.eghisLayoutControl1.TabIndex = 1;
            this.eghisLayoutControl1.Text = "eghisLayoutControl1";
            // 
            // TxtBCost
            // 
            this.TxtBCost.AutoFillHeight = true;
            this.TxtBCost.AutoFontSizeChange = true;
            this.TxtBCost.BorderStyle = eGhis.Controls.CustomBorderStyle.SingleBorder;
            this.TxtBCost.CharacterCasingType = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBCost.EmptyHintText = "";
            this.TxtBCost.Location = new System.Drawing.Point(118, 74);
            this.TxtBCost.Name = "TxtBCost";
            this.TxtBCost.PasswordChar = '\0';
            this.TxtBCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtBCost.ReadonlyType = false;
            this.TxtBCost.Size = new System.Drawing.Size(146, 20);
            this.TxtBCost.StyleController = this.eghisLayoutControl1;
            this.TxtBCost.TabIndex = 4;
            this.TxtBCost.TextInputType = eGhis.Controls.TextInputType.Default;
            this.TxtBCost.TextMaskType = eGhis.Controls.TextMaskType.None;
            this.TxtBCost.UseNumericSeparator = false;
            // 
            // TxtBAnthor
            // 
            this.TxtBAnthor.AutoFillHeight = true;
            this.TxtBAnthor.AutoFontSizeChange = true;
            this.TxtBAnthor.BorderStyle = eGhis.Controls.CustomBorderStyle.SingleBorder;
            this.TxtBAnthor.CharacterCasingType = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBAnthor.EmptyHintText = "";
            this.TxtBAnthor.Location = new System.Drawing.Point(118, 50);
            this.TxtBAnthor.Name = "TxtBAnthor";
            this.TxtBAnthor.PasswordChar = '\0';
            this.TxtBAnthor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtBAnthor.ReadonlyType = false;
            this.TxtBAnthor.Size = new System.Drawing.Size(146, 20);
            this.TxtBAnthor.StyleController = this.eghisLayoutControl1;
            this.TxtBAnthor.TabIndex = 3;
            this.TxtBAnthor.TextInputType = eGhis.Controls.TextInputType.Default;
            this.TxtBAnthor.TextMaskType = eGhis.Controls.TextMaskType.None;
            this.TxtBAnthor.UseNumericSeparator = false;
            // 
            // TxtBNm
            // 
            this.TxtBNm.AutoFillHeight = true;
            this.TxtBNm.AutoFontSizeChange = true;
            this.TxtBNm.BorderStyle = eGhis.Controls.CustomBorderStyle.SingleBorder;
            this.TxtBNm.CharacterCasingType = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBNm.EmptyHintText = "";
            this.TxtBNm.Location = new System.Drawing.Point(118, 26);
            this.TxtBNm.Name = "TxtBNm";
            this.TxtBNm.PasswordChar = '\0';
            this.TxtBNm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtBNm.ReadonlyType = false;
            this.TxtBNm.Size = new System.Drawing.Size(146, 20);
            this.TxtBNm.StyleController = this.eghisLayoutControl1;
            this.TxtBNm.TabIndex = 2;
            this.TxtBNm.TextInputType = eGhis.Controls.TextInputType.Default;
            this.TxtBNm.TextMaskType = eGhis.Controls.TextMaskType.None;
            this.TxtBNm.UseNumericSeparator = false;
            // 
            // TxtBId
            // 
            this.TxtBId.AutoFillHeight = true;
            this.TxtBId.AutoFontSizeChange = true;
            this.TxtBId.BorderStyle = eGhis.Controls.CustomBorderStyle.SingleBorder;
            this.TxtBId.CharacterCasingType = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtBId.EmptyHintText = "";
            this.TxtBId.Location = new System.Drawing.Point(118, 2);
            this.TxtBId.Name = "TxtBId";
            this.TxtBId.PasswordChar = '\0';
            this.TxtBId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.TxtBId.ReadonlyType = false;
            this.TxtBId.Size = new System.Drawing.Size(146, 20);
            this.TxtBId.StyleController = this.eghisLayoutControl1;
            this.TxtBId.TabIndex = 0;
            this.TxtBId.TextInputType = eGhis.Controls.TextInputType.Default;
            this.TxtBId.TextMaskType = eGhis.Controls.TextMaskType.None;
            this.TxtBId.UseNumericSeparator = false;
            // 
            // Root
            // 
            this.Root.AppearanceItemCaption.Options.UseTextOptions = true;
            this.Root.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(266, 96);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.Control = this.TxtBId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(266, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(266, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "도서ID (b_id)";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(104, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem2.Control = this.TxtBNm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem2.Text = "도서제목 (b_nm)";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(104, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem3.Control = this.TxtBAnthor;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem3.Text = "도서저자 (b_anthor)";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(104, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem4.Control = this.TxtBCost;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(266, 24);
            this.layoutControlItem4.Text = "도서가격 (b_cost)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(104, 14);
            // 
            // eghisTablePanel1
            // 
            this.eghisTablePanel1.AutoFontSizeChange = true;
            this.eghisTablePanel1.CellBorder = eGhis.Controls.CellBorderStyle.None;
            this.eghisTablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.eghisTablePanel1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.eghisTablePanel1.Controls.Add(this.BtnClose);
            this.eghisTablePanel1.Controls.Add(this.BtnDelete);
            this.eghisTablePanel1.Controls.Add(this.BtnSave);
            this.eghisTablePanel1.Controls.Add(this.BtnReset);
            this.eghisTablePanel1.Location = new System.Drawing.Point(330, 9);
            this.eghisTablePanel1.Name = "eghisTablePanel1";
            this.eghisTablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.eghisTablePanel1.Size = new System.Drawing.Size(258, 82);
            this.eghisTablePanel1.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose._IconType = eGhis.Controls.IconType.None;
            this.BtnClose.AutoFontSizeChange = true;
            this.BtnClose.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnClose.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.eghisTablePanel1.SetColumn(this.BtnClose, 3);
            this.BtnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnClose.ImageOptions.SvgImage")));
            this.BtnClose.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnClose.Location = new System.Drawing.Point(195, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.eghisTablePanel1.SetRow(this.BtnClose, 0);
            this.BtnClose.Size = new System.Drawing.Size(63, 59);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "닫기";
            // 
            // BtnDelete
            // 
            this.BtnDelete._IconType = eGhis.Controls.IconType.None;
            this.BtnDelete.AutoFontSizeChange = true;
            this.BtnDelete.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnDelete.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.eghisTablePanel1.SetColumn(this.BtnDelete, 2);
            this.BtnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDelete.ImageOptions.SvgImage")));
            this.BtnDelete.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnDelete.Location = new System.Drawing.Point(130, 11);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.eghisTablePanel1.SetRow(this.BtnDelete, 0);
            this.BtnDelete.Size = new System.Drawing.Size(63, 59);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "삭제";
            // 
            // BtnSave
            // 
            this.BtnSave._IconType = eGhis.Controls.IconType.None;
            this.BtnSave.AutoFontSizeChange = true;
            this.BtnSave.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnSave.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.eghisTablePanel1.SetColumn(this.BtnSave, 1);
            this.BtnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnSave.ImageOptions.SvgImage")));
            this.BtnSave.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnSave.Location = new System.Drawing.Point(66, 11);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.eghisTablePanel1.SetRow(this.BtnSave, 0);
            this.BtnSave.Size = new System.Drawing.Size(63, 59);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "저장";
            // 
            // BtnReset
            // 
            this.BtnReset._IconType = eGhis.Controls.IconType.None;
            this.BtnReset.AutoFontSizeChange = true;
            this.BtnReset.ButtonActionPosition = eGhis.Controls.ButtonActionPosition.Left;
            this.BtnReset.ButtonActionType = eGhis.Controls.ButtonActionType.None;
            this.eghisTablePanel1.SetColumn(this.BtnReset, 0);
            this.BtnReset.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.BtnReset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnReset.ImageOptions.SvgImage")));
            this.BtnReset.ImageSize = new System.Drawing.Size(0, 0);
            this.BtnReset.Location = new System.Drawing.Point(1, 11);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.PreFixedButtonSize = eGhis.Controls.PreFixedWidth.None;
            this.eghisTablePanel1.SetRow(this.BtnReset, 0);
            this.BtnReset.Size = new System.Drawing.Size(63, 59);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "초기화";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 368);
            this.Controls.Add(this.eghisTablePanel1);
            this.Controls.Add(this.eghisLayoutControl1);
            this.Controls.Add(this.eghisGroupBox1);
            this.Name = "Book";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관리시스템 > 도서관리";
            ((System.ComponentModel.ISupportInitialize)(this.eghisGroupBox1)).EndInit();
            this.eghisGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eghisLayoutControl1)).EndInit();
            this.eghisLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBAnthor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBNm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eghisTablePanel1)).EndInit();
            this.eghisTablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eGhis.Controls.EghisGroupBox eghisGroupBox1;
        private eGhis.Controls.EghisLayoutControl eghisLayoutControl1;
        private eGhis.Controls.EghisTextBox TxtBCost;
        private eGhis.Controls.EghisTextBox TxtBAnthor;
        private eGhis.Controls.EghisTextBox TxtBNm;
        private eGhis.Controls.EghisTextBox TxtBId;
        private eGhis.Controls.EghisLayoutGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private eGhis.Controls.EghisDataGrid GridSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private eGhis.Controls.EghisTablePanel eghisTablePanel1;
        private eGhis.Controls.EghisButton BtnClose;
        private eGhis.Controls.EghisButton BtnDelete;
        private eGhis.Controls.EghisButton BtnSave;
        private eGhis.Controls.EghisButton BtnReset;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}