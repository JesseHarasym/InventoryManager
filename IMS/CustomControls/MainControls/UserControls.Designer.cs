﻿namespace IMS.CustomControls
{
    partial class UserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.boxSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnModifyOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnResetOrders = new System.Windows.Forms.Button();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.btnSeeAllPreOrders = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.boxSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.lblTable);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(13, 17);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(642, 84);
            this.pnlSearch.TabIndex = 30;
            // 
            // boxSearch
            // 
            this.boxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSearch.FormattingEnabled = true;
            this.boxSearch.Location = new System.Drawing.Point(304, 11);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(163, 29);
            this.boxSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(67, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(155, 21);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Enter Search Word:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(67, 14);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(235, 21);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Choose Table To Search From:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(487, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(228, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 29);
            this.txtSearch.TabIndex = 7;
            // 
            // btnModifyOrders
            // 
            this.btnModifyOrders.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnModifyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifyOrders.Location = new System.Drawing.Point(122, 125);
            this.btnModifyOrders.Name = "btnModifyOrders";
            this.btnModifyOrders.Size = new System.Drawing.Size(114, 34);
            this.btnModifyOrders.TabIndex = 26;
            this.btnModifyOrders.Text = "Modify Order";
            this.btnModifyOrders.UseVisualStyleBackColor = false;
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDeleteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteOrders.Location = new System.Drawing.Point(242, 125);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(109, 34);
            this.btnDeleteOrders.TabIndex = 27;
            this.btnDeleteOrders.Text = "Delete Order";
            this.btnDeleteOrders.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddOrder.Location = new System.Drawing.Point(13, 125);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(103, 34);
            this.btnAddOrder.TabIndex = 28;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // btnResetOrders
            // 
            this.btnResetOrders.BackColor = System.Drawing.Color.SlateBlue;
            this.btnResetOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetOrders.Location = new System.Drawing.Point(580, 123);
            this.btnResetOrders.Name = "btnResetOrders";
            this.btnResetOrders.Size = new System.Drawing.Size(75, 34);
            this.btnResetOrders.TabIndex = 31;
            this.btnResetOrders.Text = "Reset";
            this.btnResetOrders.UseVisualStyleBackColor = false;
            this.btnResetOrders.Click += new System.EventHandler(this.btnResetOrders_Click);
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrders.Location = new System.Drawing.Point(13, 179);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.Size = new System.Drawing.Size(643, 213);
            this.dataGridOrders.TabIndex = 25;
            // 
            // btnSeeAllPreOrders
            // 
            this.btnSeeAllPreOrders.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSeeAllPreOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeAllPreOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllPreOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeeAllPreOrders.Location = new System.Drawing.Point(422, 123);
            this.btnSeeAllPreOrders.Name = "btnSeeAllPreOrders";
            this.btnSeeAllPreOrders.Size = new System.Drawing.Size(153, 34);
            this.btnSeeAllPreOrders.TabIndex = 29;
            this.btnSeeAllPreOrders.Text = "See All Pre-Orders";
            this.btnSeeAllPreOrders.UseVisualStyleBackColor = false;
            this.btnSeeAllPreOrders.Click += new System.EventHandler(this.btnSeeAllPreOrders_Click);
            // 
            // UserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnModifyOrders);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnResetOrders);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.btnSeeAllPreOrders);
            this.Name = "UserControls";
            this.Size = new System.Drawing.Size(684, 413);
            this.Load += new System.EventHandler(this.UserControls_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ComboBox boxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnModifyOrders;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnResetOrders;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btnSeeAllPreOrders;
    }
}
