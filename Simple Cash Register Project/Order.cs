using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Cash_Register_Project
{
	class Order
	{

		private Products _currentItem;
		private int _units;




		public Order()
		{
			_currentItem = new Products();
			_units = 0;
		}
		public Order(Products currentItem, int units)
		{
			_currentItem = currentItem;
			_units = units;
		}


		public Products CurrentProduct
		{
			set
			{
				_currentItem = value;
			}
			get
			{
				return _currentItem;
			}
		}
		public int Units
		{
			set
			{
				_units = value;
			}
			get
			{
				return _units;
			}
		}
		public Decimal Subtotal
		{
			get
			{
				if (_currentItem is null || _currentItem.ID == 0) ;
				return _currentItem.Rate * _units;
			}
		}



	}
}
