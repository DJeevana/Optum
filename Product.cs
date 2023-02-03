using System;

public Class Product
{
      public string Name { get; set; }
		  public decimal Price { get; set;}
      public int Quantity{get; set;}
      
      public Product (string[] productAtributes)
		  {
            this.Name = productAtributes[0];
            this.Price = decimal.Parse(productAtributes[1]);
            this.Quantity = productAtributes[2];
		  }
}
