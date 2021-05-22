namespace DE2_CHUNGKHOAN
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mACPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAMUA3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLMUA3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAMUA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLMUA2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAMUA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLMUA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIAKHOPLENHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLKHOPLENHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABAN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLBAN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABAN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLBAN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIABAN3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLBAN3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPGETROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cKDataSet = new DE2_CHUNGKHOAN.CKDataSet();
            this.sP_GETROWTableAdapter = new DE2_CHUNGKHOAN.CKDataSetTableAdapters.SP_GETROWTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(477, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "BẢNG GIÁ TRỰC TUYẾN";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mACPDataGridViewTextBoxColumn,
            this.gIAMUA3DataGridViewTextBoxColumn,
            this.kLMUA3DataGridViewTextBoxColumn,
            this.gIAMUA2DataGridViewTextBoxColumn,
            this.kLMUA2DataGridViewTextBoxColumn,
            this.gIAMUA1DataGridViewTextBoxColumn,
            this.kLMUA1DataGridViewTextBoxColumn,
            this.gIAKHOPLENHDataGridViewTextBoxColumn,
            this.kLKHOPLENHDataGridViewTextBoxColumn,
            this.gIABAN1DataGridViewTextBoxColumn,
            this.kLBAN1DataGridViewTextBoxColumn,
            this.gIABAN2DataGridViewTextBoxColumn,
            this.kLBAN2DataGridViewTextBoxColumn,
            this.gIABAN3DataGridViewTextBoxColumn,
            this.kLBAN3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPGETROWBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 314);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mACPDataGridViewTextBoxColumn
            // 
            this.mACPDataGridViewTextBoxColumn.DataPropertyName = "MACP";
            this.mACPDataGridViewTextBoxColumn.FillWeight = 388.3249F;
            this.mACPDataGridViewTextBoxColumn.HeaderText = "MÃ CP";
            this.mACPDataGridViewTextBoxColumn.Name = "mACPDataGridViewTextBoxColumn";
            this.mACPDataGridViewTextBoxColumn.Width = 51;
            // 
            // gIAMUA3DataGridViewTextBoxColumn
            // 
            this.gIAMUA3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIAMUA3DataGridViewTextBoxColumn.DataPropertyName = "GIAMUA3";
            this.gIAMUA3DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIAMUA3DataGridViewTextBoxColumn.HeaderText = "GIÁ MUA 3";
            this.gIAMUA3DataGridViewTextBoxColumn.Name = "gIAMUA3DataGridViewTextBoxColumn";
            // 
            // kLMUA3DataGridViewTextBoxColumn
            // 
            this.kLMUA3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLMUA3DataGridViewTextBoxColumn.DataPropertyName = "KLMUA3";
            this.kLMUA3DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLMUA3DataGridViewTextBoxColumn.HeaderText = "KL MUA 3";
            this.kLMUA3DataGridViewTextBoxColumn.Name = "kLMUA3DataGridViewTextBoxColumn";
            // 
            // gIAMUA2DataGridViewTextBoxColumn
            // 
            this.gIAMUA2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIAMUA2DataGridViewTextBoxColumn.DataPropertyName = "GIAMUA2";
            this.gIAMUA2DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIAMUA2DataGridViewTextBoxColumn.HeaderText = "GIÁ MUA 2";
            this.gIAMUA2DataGridViewTextBoxColumn.Name = "gIAMUA2DataGridViewTextBoxColumn";
            // 
            // kLMUA2DataGridViewTextBoxColumn
            // 
            this.kLMUA2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLMUA2DataGridViewTextBoxColumn.DataPropertyName = "KLMUA2";
            this.kLMUA2DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLMUA2DataGridViewTextBoxColumn.HeaderText = "KL MUA 2";
            this.kLMUA2DataGridViewTextBoxColumn.Name = "kLMUA2DataGridViewTextBoxColumn";
            // 
            // gIAMUA1DataGridViewTextBoxColumn
            // 
            this.gIAMUA1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIAMUA1DataGridViewTextBoxColumn.DataPropertyName = "GIAMUA1";
            this.gIAMUA1DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIAMUA1DataGridViewTextBoxColumn.HeaderText = "GIÁ MUA 1";
            this.gIAMUA1DataGridViewTextBoxColumn.Name = "gIAMUA1DataGridViewTextBoxColumn";
            // 
            // kLMUA1DataGridViewTextBoxColumn
            // 
            this.kLMUA1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLMUA1DataGridViewTextBoxColumn.DataPropertyName = "KLMUA1";
            this.kLMUA1DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLMUA1DataGridViewTextBoxColumn.HeaderText = "KL MUA 1";
            this.kLMUA1DataGridViewTextBoxColumn.Name = "kLMUA1DataGridViewTextBoxColumn";
            // 
            // gIAKHOPLENHDataGridViewTextBoxColumn
            // 
            this.gIAKHOPLENHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIAKHOPLENHDataGridViewTextBoxColumn.DataPropertyName = "GIAKHOPLENH";
            this.gIAKHOPLENHDataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIAKHOPLENHDataGridViewTextBoxColumn.HeaderText = "GIÁ KHỚP LỆNH";
            this.gIAKHOPLENHDataGridViewTextBoxColumn.Name = "gIAKHOPLENHDataGridViewTextBoxColumn";
            // 
            // kLKHOPLENHDataGridViewTextBoxColumn
            // 
            this.kLKHOPLENHDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLKHOPLENHDataGridViewTextBoxColumn.DataPropertyName = "KLKHOPLENH";
            this.kLKHOPLENHDataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLKHOPLENHDataGridViewTextBoxColumn.HeaderText = "KL KHỚP LỆNH";
            this.kLKHOPLENHDataGridViewTextBoxColumn.Name = "kLKHOPLENHDataGridViewTextBoxColumn";
            // 
            // gIABAN1DataGridViewTextBoxColumn
            // 
            this.gIABAN1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIABAN1DataGridViewTextBoxColumn.DataPropertyName = "GIABAN1";
            this.gIABAN1DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIABAN1DataGridViewTextBoxColumn.HeaderText = "GIÁ BÁN 1";
            this.gIABAN1DataGridViewTextBoxColumn.Name = "gIABAN1DataGridViewTextBoxColumn";
            // 
            // kLBAN1DataGridViewTextBoxColumn
            // 
            this.kLBAN1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLBAN1DataGridViewTextBoxColumn.DataPropertyName = "KLBAN1";
            this.kLBAN1DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLBAN1DataGridViewTextBoxColumn.HeaderText = "KL BÁN 1";
            this.kLBAN1DataGridViewTextBoxColumn.Name = "kLBAN1DataGridViewTextBoxColumn";
            // 
            // gIABAN2DataGridViewTextBoxColumn
            // 
            this.gIABAN2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIABAN2DataGridViewTextBoxColumn.DataPropertyName = "GIABAN2";
            this.gIABAN2DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIABAN2DataGridViewTextBoxColumn.HeaderText = "GIÁ BÁN 2";
            this.gIABAN2DataGridViewTextBoxColumn.Name = "gIABAN2DataGridViewTextBoxColumn";
            // 
            // kLBAN2DataGridViewTextBoxColumn
            // 
            this.kLBAN2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLBAN2DataGridViewTextBoxColumn.DataPropertyName = "KLBAN2";
            this.kLBAN2DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLBAN2DataGridViewTextBoxColumn.HeaderText = "KL BÁN 2";
            this.kLBAN2DataGridViewTextBoxColumn.Name = "kLBAN2DataGridViewTextBoxColumn";
            // 
            // gIABAN3DataGridViewTextBoxColumn
            // 
            this.gIABAN3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gIABAN3DataGridViewTextBoxColumn.DataPropertyName = "GIABAN3";
            this.gIABAN3DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.gIABAN3DataGridViewTextBoxColumn.HeaderText = "GIÁ BÁN 3";
            this.gIABAN3DataGridViewTextBoxColumn.Name = "gIABAN3DataGridViewTextBoxColumn";
            // 
            // kLBAN3DataGridViewTextBoxColumn
            // 
            this.kLBAN3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kLBAN3DataGridViewTextBoxColumn.DataPropertyName = "KLBAN3";
            this.kLBAN3DataGridViewTextBoxColumn.FillWeight = 79.40536F;
            this.kLBAN3DataGridViewTextBoxColumn.HeaderText = "KL BÁN 3";
            this.kLBAN3DataGridViewTextBoxColumn.Name = "kLBAN3DataGridViewTextBoxColumn";
            // 
            // sPGETROWBindingSource
            // 
            this.sPGETROWBindingSource.DataMember = "SP_GETROW";
            this.sPGETROWBindingSource.DataSource = this.cKDataSet;
            // 
            // cKDataSet
            // 
            this.cKDataSet.DataSetName = "CKDataSet";
            this.cKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_GETROWTableAdapter
            // 
            this.sP_GETROWTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPGETROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cKDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CKDataSet cKDataSet;
        private System.Windows.Forms.BindingSource sPGETROWBindingSource;
        private CKDataSetTableAdapters.SP_GETROWTableAdapter sP_GETROWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAMUA3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLMUA3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAMUA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLMUA2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAMUA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLMUA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIAKHOPLENHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLKHOPLENHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABAN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLBAN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABAN2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLBAN2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIABAN3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kLBAN3DataGridViewTextBoxColumn;
    }
}

