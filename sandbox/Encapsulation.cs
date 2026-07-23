// Example of Encapsulation using the soda machine scenario:


//_coins is private and must be changed through the public method InsertMoney()
public class SodaMachine
{
    private int _coins = 0;

    public void InsertMoney(int amount)
    {
        if (amount > 0)
            _coins += amount;

    }
}