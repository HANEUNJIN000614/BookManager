namespace EunJinBookManager
{
    partial class customersSearch
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
            this.eghisGroupBox1 = new eGhis.Controls.EghisGroupBox();
            this.GridSearch = new eGhis.Controls.EghisDataGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.eghisGroupBox1)).BeginInit();
            this.eghisGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // eghisGroupBox1
            // 
            this.eghisGroupBox1.AutoFontSizeChange = true;
            this.eghisGroupBox1.Controls.Add(this.GridSearch);
            this.eghisGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eghisGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.eghisGroupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.eghisGroupBox1.Name = "eghisGroupBox1";
            this.eghisGroupBox1.Size = new System.Drawing.Size(800, 450);
            this.eghisGroupBox1.TabIndex = 1;
            this.eghisGroupBox1.Text = "고객 정보 조회";
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
            this.GridSearch.Size = new System.Drawing.Size(796, 425);
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
            // customersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eghisGroupBox1);
            this.Name = "customersSearch";
            this.Text = "customersSearch";
            ((System.ComponentModel.ISupportInitialize)(this.eghisGroupBox1)).EndInit();
            this.eghisGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private eGhis.Controls.EghisGroupBox eghisGroupBox1;
        private eGhis.Controls.EghisDataGrid GridSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}