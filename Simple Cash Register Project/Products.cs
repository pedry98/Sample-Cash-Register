using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Cash_Register_Project
{
	class Products
	{
		private int _id;
		private String _itemName;
		private Decimal _rate;

		public Products()
		{
			_id = 0;
			_itemName = "";
			_rate = 0M;
		}
		/// <summary>
		/// Constructor that intantiates...
		/// </summary>
		/// <param name="id">Identification Number</param>
		/// <param name="itemName"></param>
		/// <param name="rate"></param>
		///  
		public Products(int id, String itemName, Decimal rate)
		{
			_id = id;
			_itemName = itemName;
			_rate = rate;
		}

		public int ID
		{
			set
			{
				_id = value;
			}
			get
			{
				return _id;
			}
		}
		public String ItemName
		{
			set
			{
				_itemName = value;
			}
			get
			{
				return _itemName;
			}
		}
		public Decimal Rate
		{
			set
			{
				_rate = value;
			}
			get
			{
				return _rate;
			}
		}





	}
}
