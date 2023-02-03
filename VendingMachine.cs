using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public Class VendingMachine
{
      string path = Path.Combine(Environment.CurrentDirectory, "ProductList.txt");
      List<Product> productList = new List<Product>();
            
      public VendingMachine()
      {
            InitializeVendingMachine();
	    DisplayProductList();
      }
      
      public InitializeVendingMachine()
      {
            using (StreamReader sr = new StreamReader(path))
            {
                              while(!sr.EndOfStream)
			      {
				    string currentLine = sr.ReadLine();
				    string[] currentProductAttributes currentLine.Split('$');

				    Product product = new Product(currentProductAttribues);
                                    productList.Add(product);						
                              }
            }
      }
      public DisplayProductList()
      {
      	foreach(Product p in productList)
	{
		Console.WriteLine(p.Index()+" Name: "+p.Name+" Price: "+p.Price);
	}
      }
      
      
      
}
