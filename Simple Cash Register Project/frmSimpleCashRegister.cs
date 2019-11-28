using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Cash_Register_Project
{
	public partial class frmMain : Form

	{
		private List<Products> _meals;
		private List<Order> _invoiceItems;
		private int _deliveryoption;
		private Decimal _deliveryexpenses;


		public frmMain()
		{
			InitializeComponent();
			load_order_information();
			set_columns();


			_invoiceItems = new List<Order>();
		}



		private void set_columns()
		{
			lv_items.Columns[0].Width = (lv_items.Width / 4 + 20);
			lv_items.Columns[1].Width = (lv_items.Width / 4 - 20);
			lv_items.Columns[2].Width = (lv_items.Width / 4);
			lv_items.Columns[3].Width = (lv_items.Width / 4);
		}


		private void frmMain_Load(object sender, EventArgs e)
		{


		}


		private void Update()
		{
			
			lv_items.Items.Clear();
			Decimal invoiceTotal = 0M;
			ListViewItem litem;

			foreach (Order order in _invoiceItems)
			{
				Products prod = order.CurrentProduct;
				litem = new ListViewItem(prod.ItemName);
				litem.SubItems.Add(order.Units.ToString());
				litem.SubItems.Add(prod.Rate.ToString("c"));
				litem.SubItems.Add(order.Subtotal.ToString("c"));
				invoiceTotal += order.Subtotal;
				lv_items.Items.Add(litem);
			}

			txb_subtotal.Text = invoiceTotal.ToString("c");
			Decimal taxes = invoiceTotal * (decimal)0.07;
			txb_salestax.Text = taxes.ToString("c25").TrimEnd('0');
			txb_total.Text = (taxes + invoiceTotal + _deliveryexpenses).ToString("c25").TrimEnd('0');
		}



		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void load_order_information()
		{
			_meals = new List<Products>();

			Products temp = new Products();

			//first item
			temp.ID = 1;
			temp.ItemName = "Burger";
			temp.Rate = 4.99M;
			_meals.Add(temp);

			 temp = new Products();

			//second item
			temp.ID = 2;
			temp.ItemName = "Fries";
			temp.Rate = 3.99M;
			_meals.Add(temp);

			temp = new Products();

			//3rd item
			temp.ID = 3;
			temp.ItemName = "SoftDrink";
			temp.Rate = 2.99M;
			_meals.Add(temp);

			 temp = new Products();
			//4th item
			temp.ID = 4;
			temp.ItemName = "Dessert";
			temp.Rate = 1.99M;
			_meals.Add(temp);

		}





		private void btn_add_Click(object sender, EventArgs e)
		{
			delivery();
			if (rb_zone1.Checked == false && rb_zone2.Checked == false && rb_zone3.Checked == false && rb_eatin.Checked == false)
			{

				MessageBox.Show("Please select an item for the Food Menu.");
				gbFoodMenu.ForeColor = Color.Red;
				return;
			}
			else
				gbFoodMenu.ForeColor = Color.Black;
			
			if (rb_burger.Checked == false && rb_fries.Checked == false && rb_softdrink.Checked == false && rb_dessert.Checked == false)
			{
				MessageBox.Show("Please select a delivery option.");
				gbFoodMenu.ForeColor = Color.Red;
				return;
			}

			else
				gbFoodMenu.ForeColor = Color.Black;

			//Convert DateTime value 

			int count = Convert.ToInt32(num_Qty.Value);
			try
			{


				if (count == 0)
				{
					throw new Exception("Invalid! Minimum quantity is 1.");
				}

				if (add_to_list(count) == false)
				{
					throw new Exception("Error adding item to list");


				}
				Update();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}



		}
		private void delivery()
		{

			
			if (rb_zone1.Checked == true)
			{
				_deliveryoption = 1;
				_deliveryexpenses = 2;
			}
			else
				if (rb_zone2.Checked == true)
			{
				_deliveryoption = 2;
				_deliveryexpenses = 3;

			}
			else
					if (rb_zone3.Checked == true)
			{
				_deliveryoption = 3;
				_deliveryexpenses = 3;

			}
			else
				if (rb_eatin.Checked == true)
			{
				_deliveryoption = 4;
				_deliveryexpenses = 0;

			}

			if (_deliveryoption == 1)
				txb_delivery.Text = 2.00M.ToString("c");
			if (_deliveryoption == 2)
				txb_delivery.Text = 3.00M.ToString("c");
			if (_deliveryoption == 3)
				txb_delivery.Text = 3.00M.ToString("c");
			if (_deliveryoption == 4)
				txb_delivery.Text = 0.00M.ToString("c");

		}
		private bool add_to_list(int orders)
		{
			try
			{
				//Hold a temporary item that will be added to the invoice list
				Products _currentProduct = new Products();

				//I will use the original ID's as indexes. Remember these
				if (rb_burger.Checked)
				{
					_currentProduct = _meals[0];
				}
				else if (rb_fries.Checked)
				{
					_currentProduct = _meals[1];
				}
				else if (rb_softdrink.Checked)
				{
					_currentProduct = _meals[2];
				}
				else if (rb_dessert.Checked)
				{
					_currentProduct = _meals[3];
				}
				else
				{
					throw new Exception();
				}

				Order _currentOrder = new Order(_currentProduct, orders);
				_invoiceItems.Add(_currentOrder);

				return true;
			}
			catch
			{
				return false;
			}
		}

		private void btn_remove_Click(object sender, EventArgs e)
		{
			try
			{
				ListViewItem litem = lv_items.SelectedItems[0];
				Order _currentItems;

				for (int i = 0; i < _invoiceItems.Count; i++)
				{
					_currentItems = _invoiceItems[i];
					if (_currentItems.CurrentProduct.ItemName == litem.Text)
					{
						_invoiceItems.RemoveAt(i);
						Update();
						if (lv_items.Items.Count == 0)
						{
							txb_subtotal.Text = "";
							txb_delivery.Text = "";
							txb_total.Text = "";
							txb_salestax.Text = "";

						}
						return;
					}
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Please select the item you want to remove");
			}
		}
		private void btn_clear_Click(object sender, EventArgs e)
		{
			rb_burger.Checked = false;
			rb_fries.Checked = false;
			rb_softdrink.Checked = false;
			rb_dessert.Checked = false;
			rb_zone1.Checked = false;
			rb_zone2.Checked = false;
			rb_zone3.Checked = false;
			rb_eatin.Checked = false;
			txb_subtotal.Text = "";
			txb_delivery.Text = "";
			txb_salestax.Text = "";
			txb_total.Text = "";


			_invoiceItems.Clear();
			lv_items.Items.Clear();
		}
	}
}
			

			

			




			


	
	





