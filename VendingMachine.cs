using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public Class VendingMachine
{
      string path = Path.Combine(Environment.CurrentDirectory, "ProductList.txt");
      public VendingMachine()
      {
            InitializeVendingMachine();
      }
      
      public InitializeVendingMachine()
      {
            List<Product> productList = new List<Product>();
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
      
      
}
