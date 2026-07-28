public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public int getTotalPrice()
    {
        int totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.getTotal();
        }
        if (_customer.isUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
    public string getPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += product.getName() + " (ID: " + product.getProductID() + ")\n";
        }
        return packingLabel;
    }
    public string getShippingLabel()
    {
        string shippingLabel = "";
        shippingLabel += _customer.getName() + "\n" +_customer.getAddress().getFullAddress();

        return shippingLabel;
    }
    
}