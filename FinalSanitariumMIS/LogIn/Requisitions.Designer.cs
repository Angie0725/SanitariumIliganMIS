namespace LogIn
{
    partial class Requisitions
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkback = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_remove_item = new System.Windows.Forms.Button();
            this.btn_additem = new System.Windows.Forms.Button();
            this.btn_save_request = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_requesition_details = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_requesition_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_requested_by = new System.Windows.Forms.TextBox();
            this.cb_wardnames = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_requesition_list = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_request_history_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_add_stock = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_add_items = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_item_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel_add_stock = new System.Windows.Forms.Button();
            this.btn_add_stock = new System.Windows.Forms.Button();
            this.tb_stock_quantity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requesition_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requesition_list)).BeginInit();
            this.panel_add_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_items)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.linkback);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 123);
            this.panel1.TabIndex = 39;
            // 
            // linkback
            // 
            this.linkback.AutoSize = true;
            this.linkback.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkback.Location = new System.Drawing.Point(1016, 84);
            this.linkback.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkback.Name = "linkback";
            this.linkback.Size = new System.Drawing.Size(240, 29);
            this.linkback.TabIndex = 59;
            this.linkback.Text = "Go back to Main Menu";
            this.linkback.Click += new System.EventHandler(this.linkback_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Management Information System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "SANITARIUM HOSPITAL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_remove_item);
            this.groupBox2.Controls.Add(this.btn_additem);
            this.groupBox2.Controls.Add(this.btn_save_request);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgv_requesition_details);
            this.groupBox2.Controls.Add(this.tb_requesition_number);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_requested_by);
            this.groupBox2.Controls.Add(this.cb_wardnames);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1219, 316);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NEW REQUESITION";
            // 
            // btn_remove_item
            // 
            this.btn_remove_item.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_remove_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove_item.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_item.Location = new System.Drawing.Point(838, 23);
            this.btn_remove_item.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove_item.Name = "btn_remove_item";
            this.btn_remove_item.Size = new System.Drawing.Size(171, 33);
            this.btn_remove_item.TabIndex = 66;
            this.btn_remove_item.Text = "REMOVE ITEM";
            this.btn_remove_item.UseVisualStyleBackColor = false;
            this.btn_remove_item.Click += new System.EventHandler(this.btn_remove_item_Click);
            // 
            // btn_additem
            // 
            this.btn_additem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_additem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_additem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_additem.Location = new System.Drawing.Point(1017, 23);
            this.btn_additem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(171, 33);
            this.btn_additem.TabIndex = 65;
            this.btn_additem.Text = "ADD ITEM";
            this.btn_additem.UseVisualStyleBackColor = false;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // btn_save_request
            // 
            this.btn_save_request.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_save_request.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_request.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_request.Location = new System.Drawing.Point(28, 243);
            this.btn_save_request.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save_request.Name = "btn_save_request";
            this.btn_save_request.Size = new System.Drawing.Size(459, 43);
            this.btn_save_request.TabIndex = 58;
            this.btn_save_request.Text = "SUBMIT REQUEST";
            this.btn_save_request.UseVisualStyleBackColor = false;
            this.btn_save_request.Click += new System.EventHandler(this.btn_save_request_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Items In Request:";
            // 
            // dgv_requesition_details
            // 
            this.dgv_requesition_details.AllowUserToAddRows = false;
            this.dgv_requesition_details.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgv_requesition_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requesition_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_requesition_details.Location = new System.Drawing.Point(523, 64);
            this.dgv_requesition_details.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_requesition_details.MultiSelect = false;
            this.dgv_requesition_details.Name = "dgv_requesition_details";
            this.dgv_requesition_details.ReadOnly = true;
            this.dgv_requesition_details.RowHeadersVisible = false;
            this.dgv_requesition_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_requesition_details.Size = new System.Drawing.Size(665, 225);
            this.dgv_requesition_details.TabIndex = 57;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tb_requesition_number
            // 
            this.tb_requesition_number.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_requesition_number.Location = new System.Drawing.Point(273, 93);
            this.tb_requesition_number.Margin = new System.Windows.Forms.Padding(5);
            this.tb_requesition_number.Name = "tb_requesition_number";
            this.tb_requesition_number.Size = new System.Drawing.Size(212, 26);
            this.tb_requesition_number.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "REQUISITION NUMBER:";
            // 
            // tb_requested_by
            // 
            this.tb_requested_by.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_requested_by.Location = new System.Drawing.Point(273, 178);
            this.tb_requested_by.Margin = new System.Windows.Forms.Padding(5);
            this.tb_requested_by.Name = "tb_requested_by";
            this.tb_requested_by.Size = new System.Drawing.Size(212, 26);
            this.tb_requested_by.TabIndex = 58;
            // 
            // cb_wardnames
            // 
            this.cb_wardnames.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_wardnames.FormattingEnabled = true;
            this.cb_wardnames.Location = new System.Drawing.Point(273, 134);
            this.cb_wardnames.Margin = new System.Windows.Forms.Padding(4);
            this.cb_wardnames.Name = "cb_wardnames";
            this.cb_wardnames.Size = new System.Drawing.Size(212, 26);
            this.cb_wardnames.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 138);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 18);
            this.label15.TabIndex = 56;
            this.label15.Text = "REQUISITION FOR (WARD NAME):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "REQUESTED BY:";
            // 
            // dgv_requesition_list
            // 
            this.dgv_requesition_list.AllowUserToAddRows = false;
            this.dgv_requesition_list.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgv_requesition_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_requesition_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_requesition_list.Location = new System.Drawing.Point(25, 178);
            this.dgv_requesition_list.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_requesition_list.MultiSelect = false;
            this.dgv_requesition_list.Name = "dgv_requesition_list";
            this.dgv_requesition_list.ReadOnly = true;
            this.dgv_requesition_list.RowHeadersVisible = false;
            this.dgv_requesition_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_requesition_list.Size = new System.Drawing.Size(1219, 310);
            this.dgv_requesition_list.TabIndex = 66;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Requesition Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Staff Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ward Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date Requested";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tb_request_history_search
            // 
            this.tb_request_history_search.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_request_history_search.Location = new System.Drawing.Point(1020, 143);
            this.tb_request_history_search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_request_history_search.Name = "tb_request_history_search";
            this.tb_request_history_search.Size = new System.Drawing.Size(224, 26);
            this.tb_request_history_search.TabIndex = 68;
            this.tb_request_history_search.TextChanged += new System.EventHandler(this.tb_request_history_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(961, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 67;
            this.label6.Text = "SEARCH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 69;
            this.label7.Text = "Request History:";
            // 
            // panel_add_stock
            // 
            this.panel_add_stock.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_add_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_add_stock.Controls.Add(this.label8);
            this.panel_add_stock.Controls.Add(this.dgv_add_items);
            this.panel_add_stock.Controls.Add(this.tb_item_search);
            this.panel_add_stock.Controls.Add(this.label2);
            this.panel_add_stock.Controls.Add(this.btn_cancel_add_stock);
            this.panel_add_stock.Controls.Add(this.btn_add_stock);
            this.panel_add_stock.Controls.Add(this.tb_stock_quantity);
            this.panel_add_stock.Controls.Add(this.label19);
            this.panel_add_stock.Controls.Add(this.label18);
            this.panel_add_stock.Location = new System.Drawing.Point(361, 143);
            this.panel_add_stock.Margin = new System.Windows.Forms.Padding(4);
            this.panel_add_stock.Name = "panel_add_stock";
            this.panel_add_stock.Size = new System.Drawing.Size(563, 378);
            this.panel_add_stock.TabIndex = 100;
            this.panel_add_stock.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 18);
            this.label8.TabIndex = 108;
            this.label8.Text = "SELECT AN ITEM FROM THE LIST";
            // 
            // dgv_add_items
            // 
            this.dgv_add_items.AllowUserToAddRows = false;
            this.dgv_add_items.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgv_add_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_add_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_add_items.Location = new System.Drawing.Point(19, 123);
            this.dgv_add_items.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_add_items.MultiSelect = false;
            this.dgv_add_items.Name = "dgv_add_items";
            this.dgv_add_items.ReadOnly = true;
            this.dgv_add_items.RowHeadersVisible = false;
            this.dgv_add_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_add_items.Size = new System.Drawing.Size(523, 181);
            this.dgv_add_items.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Item Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Item";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tb_item_search
            // 
            this.tb_item_search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item_search.Location = new System.Drawing.Point(221, 85);
            this.tb_item_search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_item_search.Name = "tb_item_search";
            this.tb_item_search.Size = new System.Drawing.Size(321, 32);
            this.tb_item_search.TabIndex = 106;
            this.tb_item_search.TextChanged += new System.EventHandler(this.tb_item_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 105;
            this.label2.Text = "SEARCH ITEMS:";
            // 
            // btn_cancel_add_stock
            // 
            this.btn_cancel_add_stock.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cancel_add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel_add_stock.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_add_stock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel_add_stock.Location = new System.Drawing.Point(290, 312);
            this.btn_cancel_add_stock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel_add_stock.Name = "btn_cancel_add_stock";
            this.btn_cancel_add_stock.Size = new System.Drawing.Size(122, 43);
            this.btn_cancel_add_stock.TabIndex = 103;
            this.btn_cancel_add_stock.Text = "CANCEL";
            this.btn_cancel_add_stock.UseVisualStyleBackColor = false;
            this.btn_cancel_add_stock.Click += new System.EventHandler(this.btn_cancel_add_stock_Click);
            // 
            // btn_add_stock
            // 
            this.btn_add_stock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_stock.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_stock.Location = new System.Drawing.Point(420, 312);
            this.btn_add_stock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_stock.Name = "btn_add_stock";
            this.btn_add_stock.Size = new System.Drawing.Size(122, 43);
            this.btn_add_stock.TabIndex = 101;
            this.btn_add_stock.Text = "ADD";
            this.btn_add_stock.UseVisualStyleBackColor = false;
            this.btn_add_stock.Click += new System.EventHandler(this.btn_add_stock_Click);
            // 
            // tb_stock_quantity
            // 
            this.tb_stock_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_stock_quantity.Location = new System.Drawing.Point(124, 317);
            this.tb_stock_quantity.Margin = new System.Windows.Forms.Padding(5);
            this.tb_stock_quantity.Name = "tb_stock_quantity";
            this.tb_stock_quantity.Size = new System.Drawing.Size(153, 32);
            this.tb_stock_quantity.TabIndex = 96;
            this.tb_stock_quantity.TextChanged += new System.EventHandler(this.tb_stock_quantity_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 320);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 24);
            this.label19.TabIndex = 95;
            this.label19.Text = "QUANTITY:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 13);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(238, 33);
            this.label18.TabIndex = 100;
            this.label18.Text = "ADD REQUEST ITEM";
            // 
            // Requisitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1269, 852);
            this.Controls.Add(this.panel_add_stock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_request_history_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_requesition_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Requisitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WARD REQUISITIONS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requesition_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requesition_list)).EndInit();
            this.panel_add_stock.ResumeLayout(false);
            this.panel_add_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_add_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_requested_by;
        private System.Windows.Forms.ComboBox cb_wardnames;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_requesition_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_requesition_details;
        private System.Windows.Forms.Button btn_save_request;
        private System.Windows.Forms.Label linkback;
        private System.Windows.Forms.Button btn_remove_item;
        private System.Windows.Forms.DataGridView dgv_requesition_list;
        private System.Windows.Forms.TextBox tb_request_history_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel_add_stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_add_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox tb_item_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel_add_stock;
        private System.Windows.Forms.Button btn_add_stock;
        private System.Windows.Forms.TextBox tb_stock_quantity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}