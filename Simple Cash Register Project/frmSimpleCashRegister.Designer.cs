namespace Simple_Cash_Register_Project
{
	partial class frmMain
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
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
			this.gbFoodMenu = new System.Windows.Forms.GroupBox();
			this.rb_dessert = new System.Windows.Forms.RadioButton();
			this.rb_softdrink = new System.Windows.Forms.RadioButton();
			this.rb_fries = new System.Windows.Forms.RadioButton();
			this.rb_burger = new System.Windows.Forms.RadioButton();
			this.num_Qty = new System.Windows.Forms.NumericUpDown();
			this.lbl_qty = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.gb_Delivery = new System.Windows.Forms.GroupBox();
			this.rb_eatin = new System.Windows.Forms.RadioButton();
			this.rb_zone3 = new System.Windows.Forms.RadioButton();
			this.rb_zone2 = new System.Windows.Forms.RadioButton();
			this.rb_zone1 = new System.Windows.Forms.RadioButton();
			this.lv_items = new System.Windows.Forms.ListView();
			this.cH1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cH2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cH3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cH4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_remove = new System.Windows.Forms.Button();
			this.lbl_subtotal = new System.Windows.Forms.Label();
			this.lbl_delivery = new System.Windows.Forms.Label();
			this.lbl_salestax = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.txb_subtotal = new System.Windows.Forms.TextBox();
			this.txb_delivery = new System.Windows.Forms.TextBox();
			this.txb_salestax = new System.Windows.Forms.TextBox();
			this.txb_total = new System.Windows.Forms.TextBox();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.gbFoodMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Qty)).BeginInit();
			this.gb_Delivery.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbFoodMenu
			// 
			this.gbFoodMenu.Controls.Add(this.rb_dessert);
			this.gbFoodMenu.Controls.Add(this.rb_softdrink);
			this.gbFoodMenu.Controls.Add(this.rb_fries);
			this.gbFoodMenu.Controls.Add(this.rb_burger);
			this.gbFoodMenu.Location = new System.Drawing.Point(22, 23);
			this.gbFoodMenu.Name = "gbFoodMenu";
			this.gbFoodMenu.Size = new System.Drawing.Size(184, 124);
			this.gbFoodMenu.TabIndex = 0;
			this.gbFoodMenu.TabStop = false;
			this.gbFoodMenu.Text = "Food Menu";
			// 
			// rb_dessert
			// 
			this.rb_dessert.AutoSize = true;
			this.rb_dessert.Location = new System.Drawing.Point(18, 100);
			this.rb_dessert.Name = "rb_dessert";
			this.rb_dessert.Size = new System.Drawing.Size(61, 17);
			this.rb_dessert.TabIndex = 4;
			this.rb_dessert.TabStop = true;
			this.rb_dessert.Text = "Dessert";
			this.rb_dessert.UseVisualStyleBackColor = true;
			// 
			// rb_softdrink
			// 
			this.rb_softdrink.AutoSize = true;
			this.rb_softdrink.Location = new System.Drawing.Point(18, 77);
			this.rb_softdrink.Name = "rb_softdrink";
			this.rb_softdrink.Size = new System.Drawing.Size(67, 17);
			this.rb_softdrink.TabIndex = 3;
			this.rb_softdrink.TabStop = true;
			this.rb_softdrink.Text = "Softdrink";
			this.rb_softdrink.UseVisualStyleBackColor = true;
			// 
			// rb_fries
			// 
			this.rb_fries.AutoSize = true;
			this.rb_fries.Location = new System.Drawing.Point(18, 54);
			this.rb_fries.Name = "rb_fries";
			this.rb_fries.Size = new System.Drawing.Size(47, 17);
			this.rb_fries.TabIndex = 2;
			this.rb_fries.TabStop = true;
			this.rb_fries.Text = "Fires";
			this.rb_fries.UseVisualStyleBackColor = true;
			// 
			// rb_burger
			// 
			this.rb_burger.AutoSize = true;
			this.rb_burger.Location = new System.Drawing.Point(18, 31);
			this.rb_burger.Name = "rb_burger";
			this.rb_burger.Size = new System.Drawing.Size(56, 17);
			this.rb_burger.TabIndex = 1;
			this.rb_burger.TabStop = true;
			this.rb_burger.Text = "Burger";
			this.rb_burger.UseVisualStyleBackColor = true;
			// 
			// num_Qty
			// 
			this.num_Qty.Location = new System.Drawing.Point(95, 148);
			this.num_Qty.Name = "num_Qty";
			this.num_Qty.Size = new System.Drawing.Size(51, 20);
			this.num_Qty.TabIndex = 1;
			// 
			// lbl_qty
			// 
			this.lbl_qty.AutoSize = true;
			this.lbl_qty.Location = new System.Drawing.Point(37, 150);
			this.lbl_qty.Name = "lbl_qty";
			this.lbl_qty.Size = new System.Drawing.Size(26, 13);
			this.lbl_qty.TabIndex = 2;
			this.lbl_qty.Text = "Qty:";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(40, 184);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(106, 23);
			this.btn_add.TabIndex = 3;
			this.btn_add.Text = "Add To Invoice";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// gb_Delivery
			// 
			this.gb_Delivery.Controls.Add(this.rb_eatin);
			this.gb_Delivery.Controls.Add(this.rb_zone3);
			this.gb_Delivery.Controls.Add(this.rb_zone2);
			this.gb_Delivery.Controls.Add(this.rb_zone1);
			this.gb_Delivery.Location = new System.Drawing.Point(22, 224);
			this.gb_Delivery.Name = "gb_Delivery";
			this.gb_Delivery.Size = new System.Drawing.Size(184, 122);
			this.gb_Delivery.TabIndex = 4;
			this.gb_Delivery.TabStop = false;
			this.gb_Delivery.Text = "Delivery Options";
			// 
			// rb_eatin
			// 
			this.rb_eatin.AutoSize = true;
			this.rb_eatin.Location = new System.Drawing.Point(18, 101);
			this.rb_eatin.Name = "rb_eatin";
			this.rb_eatin.Size = new System.Drawing.Size(90, 17);
			this.rb_eatin.TabIndex = 8;
			this.rb_eatin.TabStop = true;
			this.rb_eatin.Text = "Eat in/Pickup";
			this.rb_eatin.UseVisualStyleBackColor = true;
			// 
			// rb_zone3
			// 
			this.rb_zone3.AutoSize = true;
			this.rb_zone3.Location = new System.Drawing.Point(18, 78);
			this.rb_zone3.Name = "rb_zone3";
			this.rb_zone3.Size = new System.Drawing.Size(59, 17);
			this.rb_zone3.TabIndex = 7;
			this.rb_zone3.TabStop = true;
			this.rb_zone3.Text = "Zone 3";
			this.rb_zone3.UseVisualStyleBackColor = true;
			// 
			// rb_zone2
			// 
			this.rb_zone2.AutoSize = true;
			this.rb_zone2.Location = new System.Drawing.Point(18, 55);
			this.rb_zone2.Name = "rb_zone2";
			this.rb_zone2.Size = new System.Drawing.Size(59, 17);
			this.rb_zone2.TabIndex = 6;
			this.rb_zone2.TabStop = true;
			this.rb_zone2.Text = "Zone 2";
			this.rb_zone2.UseVisualStyleBackColor = true;
			// 
			// rb_zone1
			// 
			this.rb_zone1.AutoSize = true;
			this.rb_zone1.Location = new System.Drawing.Point(18, 32);
			this.rb_zone1.Name = "rb_zone1";
			this.rb_zone1.Size = new System.Drawing.Size(59, 17);
			this.rb_zone1.TabIndex = 5;
			this.rb_zone1.TabStop = true;
			this.rb_zone1.Text = "Zone 1";
			this.rb_zone1.UseVisualStyleBackColor = true;
			// 
			// lv_items
			// 
			this.lv_items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH1,
            this.cH2,
            this.cH3,
            this.cH4});
			this.lv_items.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
			this.lv_items.Location = new System.Drawing.Point(228, 23);
			this.lv_items.Name = "lv_items";
			this.lv_items.Size = new System.Drawing.Size(411, 252);
			this.lv_items.TabIndex = 5;
			this.lv_items.UseCompatibleStateImageBehavior = false;
			this.lv_items.View = System.Windows.Forms.View.Details;
			// 
			// cH1
			// 
			this.cH1.Text = "Item";
			// 
			// cH2
			// 
			this.cH2.Text = "Units";
			// 
			// cH3
			// 
			this.cH3.Text = "Rate";
			// 
			// cH4
			// 
			this.cH4.Text = "Subtotal";
			// 
			// btn_remove
			// 
			this.btn_remove.Location = new System.Drawing.Point(228, 298);
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(106, 23);
			this.btn_remove.TabIndex = 6;
			this.btn_remove.Text = "Remove";
			this.btn_remove.UseVisualStyleBackColor = true;
			this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
			// 
			// lbl_subtotal
			// 
			this.lbl_subtotal.AutoSize = true;
			this.lbl_subtotal.Location = new System.Drawing.Point(451, 299);
			this.lbl_subtotal.Name = "lbl_subtotal";
			this.lbl_subtotal.Size = new System.Drawing.Size(49, 13);
			this.lbl_subtotal.TabIndex = 7;
			this.lbl_subtotal.Text = "Subtotal:";
			// 
			// lbl_delivery
			// 
			this.lbl_delivery.AutoSize = true;
			this.lbl_delivery.Location = new System.Drawing.Point(452, 324);
			this.lbl_delivery.Name = "lbl_delivery";
			this.lbl_delivery.Size = new System.Drawing.Size(48, 13);
			this.lbl_delivery.TabIndex = 8;
			this.lbl_delivery.Text = "Delivery:";
			// 
			// lbl_salestax
			// 
			this.lbl_salestax.AutoSize = true;
			this.lbl_salestax.Location = new System.Drawing.Point(451, 352);
			this.lbl_salestax.Name = "lbl_salestax";
			this.lbl_salestax.Size = new System.Drawing.Size(57, 13);
			this.lbl_salestax.TabIndex = 9;
			this.lbl_salestax.Text = "Sales Tax:";
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Location = new System.Drawing.Point(451, 377);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(45, 13);
			this.lbl_total.TabIndex = 10;
			this.lbl_total.Text = "TOTAL:";
			// 
			// txb_subtotal
			// 
			this.txb_subtotal.Location = new System.Drawing.Point(539, 292);
			this.txb_subtotal.Name = "txb_subtotal";
			this.txb_subtotal.Size = new System.Drawing.Size(100, 20);
			this.txb_subtotal.TabIndex = 11;
			// 
			// txb_delivery
			// 
			this.txb_delivery.Location = new System.Drawing.Point(539, 321);
			this.txb_delivery.Name = "txb_delivery";
			this.txb_delivery.Size = new System.Drawing.Size(100, 20);
			this.txb_delivery.TabIndex = 12;
			// 
			// txb_salestax
			// 
			this.txb_salestax.Location = new System.Drawing.Point(539, 347);
			this.txb_salestax.Name = "txb_salestax";
			this.txb_salestax.Size = new System.Drawing.Size(100, 20);
			this.txb_salestax.TabIndex = 13;
			// 
			// txb_total
			// 
			this.txb_total.Location = new System.Drawing.Point(539, 374);
			this.txb_total.Name = "txb_total";
			this.txb_total.Size = new System.Drawing.Size(100, 20);
			this.txb_total.TabIndex = 14;
			// 
			// btn_clear
			// 
			this.btn_clear.Location = new System.Drawing.Point(253, 414);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(122, 37);
			this.btn_clear.TabIndex = 15;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(514, 414);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(125, 37);
			this.btn_exit.TabIndex = 16;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 462);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.txb_total);
			this.Controls.Add(this.txb_salestax);
			this.Controls.Add(this.txb_delivery);
			this.Controls.Add(this.txb_subtotal);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.lbl_salestax);
			this.Controls.Add(this.lbl_delivery);
			this.Controls.Add(this.lbl_subtotal);
			this.Controls.Add(this.btn_remove);
			this.Controls.Add(this.lv_items);
			this.Controls.Add(this.gb_Delivery);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.lbl_qty);
			this.Controls.Add(this.num_Qty);
			this.Controls.Add(this.gbFoodMenu);
			this.Name = "frmMain";
			this.Text = "Simple Cash Register";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.gbFoodMenu.ResumeLayout(false);
			this.gbFoodMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_Qty)).EndInit();
			this.gb_Delivery.ResumeLayout(false);
			this.gb_Delivery.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbFoodMenu;
		private System.Windows.Forms.RadioButton rb_dessert;
		private System.Windows.Forms.RadioButton rb_softdrink;
		private System.Windows.Forms.RadioButton rb_fries;
		private System.Windows.Forms.RadioButton rb_burger;
		private System.Windows.Forms.NumericUpDown num_Qty;
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.GroupBox gb_Delivery;
		private System.Windows.Forms.RadioButton rb_eatin;
		private System.Windows.Forms.RadioButton rb_zone3;
		private System.Windows.Forms.RadioButton rb_zone2;
		private System.Windows.Forms.RadioButton rb_zone1;
		private System.Windows.Forms.ListView lv_items;
		private System.Windows.Forms.ColumnHeader cH1;
		private System.Windows.Forms.ColumnHeader cH2;
		private System.Windows.Forms.ColumnHeader cH3;
		private System.Windows.Forms.ColumnHeader cH4;
		private System.Windows.Forms.Button btn_remove;
		private System.Windows.Forms.Label lbl_subtotal;
		private System.Windows.Forms.Label lbl_delivery;
		private System.Windows.Forms.Label lbl_salestax;
		private System.Windows.Forms.Label lbl_total;
		private System.Windows.Forms.TextBox txb_subtotal;
		private System.Windows.Forms.TextBox txb_delivery;
		private System.Windows.Forms.TextBox txb_salestax;
		private System.Windows.Forms.TextBox txb_total;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_exit;
	}
}

