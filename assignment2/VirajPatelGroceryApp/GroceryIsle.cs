using System.Collections.Generic;

public class GroceryIsle
{

    public List<FoodItem> FoodItemsList{ get; set; }
    public string isleName  { get; set; }
    public int isleNumber  { get; set; }

    public GroceryIsle()
    {
     
        FoodItemsList=new List<FoodItem>();
    }

    public void AddFoodItem(FoodItem NewFoodProducts)
    {

        
        FoodItemsList.Add(NewFoodProducts);
    }

}