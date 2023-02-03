using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

Public Class Program
{
		public statis void Main(strings[] args)
		{
			VendingMachine vmInstance=new VendingMachine();
			Console.Clear();
			Console.WriteLine("Please select a product"); // Assuming the customer would select the product code which is basically the index starting from 0
			Console.WriteLine();
			
			int index= int.Parse(Console.ReadLine());
			try
			{
				Product selectedProduct=vmInstance.productList.Get(index);
			}
			catch(Eception ex)
			{
				Console.WriteLine("Invalid input selected. Please select a valid input.");
				vmInstance.
			}
			
			
		
		}
}

