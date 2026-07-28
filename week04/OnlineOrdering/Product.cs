public class Product
{
    private string _name;
    private int _productID;
    private int _price;
    private int _quantity;

    public Product(string name, int productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string getName()
    {
        return _name;
    }
    public int getProductID()
    {
        return _productID;
    }
    public int getPrice()
    {
        return _price;
    }
    public int getQuantity()
    {
        return _quantity;
    }
    public int getTotal()
    {
        return _price * _quantity;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public void setPrice(int price)
    {
        _price = price;
    }
    public void setQuantity(int quantity)
    {
        _quantity = quantity;
    }
}