using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

Public Class Program
{
		public static void Main(strings[] args)
		{
			Product selectedProduct;
			bool validInput=false;
			int index;
			VendingMachine vmInstance=new VendingMachine();
			decimal moneyReceived=0.00;
			
			Console.Clear();
			Console.WriteLine("Please select a product"); // Assuming the customer would select the product code which is basically the index starting from 0
			Console.WriteLine();	
			
			do
			(
				index= int.Parse(Console.ReadLine());
				try
				{
					selectedProduct=vmInstance.productList.Get(index);
					if(selectedProduct.Quantity==0)
					{
						Console.WriteLine("The selected product is not available in the Inventory. Please select another product. ");
						vmInstance. DisplayProductList();
						Console.WriteLine("Please select a product");
					}
					else
					{
						validInput=true;
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine("Invalid input selected. Please select a valid input.");
					vmInstance. DisplayProductList();
					Console.WriteLine("Please select a product");
				}
			)while(!validInput);
			
			Console.WriteLine("Selected product is: "+selectedProduct.Name);
			Consle.WriteLine("Please proceed for the payment of $: "+selectedProduct.Price);
			Console.WriteLine("Accepted coins are nickels, dimes and quarters")
			
			decimal amountToBePaid=selectedProduct.Price;
			
			while(moneyReceived<amountToBePaid)
			{
				
			}
			
		
		}
}

