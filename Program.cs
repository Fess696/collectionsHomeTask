using System.Collections.Generic;
using JsonSeDe;
using Newtonsoft.Json;

class Program 
{ 
    static void Main(string[] args)
    {
        var products = GetProductLists();

        if (products != null)
        { 
            for (int i = 0; i < products.Count; i++)
            {
                System.Diagnostics.Debug.Print(products[i].Id);
	    
	        }
	    }
    }
    static List<ProductList> GetProductLists()
    {
        string fileName =
            @"/Users/nik/Projects/JsonSeDe/JsonSeDe/Data/product.json";
            
            if(File.Exists(fileName))
            {
            var products =
                JsonConvert.DeserializeObject<List<ProductList>>
                (File.ReadAllText(fileName));

            return products;
	     
	        }

        return null;
    }
}



