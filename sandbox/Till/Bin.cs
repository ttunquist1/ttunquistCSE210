class Bin
{
    private string _denomonation;
    private double _value;
    private int _count;

    public Bin(string denomination, double value, int count)
    {
        _denomonation = denomination;
        _value = value;
        _count = count;
    }

    public void Transaction(int count) 
    // value perameter should be negative for debit, positive for credit
    {
        _count += count;
    }
    
    public string GetDenomination()
    {
        return _denomonation;
    }

    public double GetValue()
    {
        return _value;
    }

    public int GetCount()
    {
        return _count;
    }

    
}