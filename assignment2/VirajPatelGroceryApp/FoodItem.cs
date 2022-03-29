public class FoodItem
{
    public int Quantity { get; set; }

    public int ProductId { get; set;}

    public string Product { get; set; }

    public int Price {get; set;}

     public void IncreaseQuaniity()
    {


        if(Quantity<20)
            Quantity++;
    }



    public void DescreaseQuaniity()
    {
        if(Quantity>0)
            Quantity--;


    }


}