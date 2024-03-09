namespace Task3;

public class Gauge
{
    public int _value;
    public Gauge()
    {
        _value=0;
    }
    public void Enhance()
    {
        if (_value<5)
        {
        _value++;
        }
    }
    public void Decrease()
    {
        if (_value>0)
        {
        _value--;
        }
    }
    public bool Full()
    {
        if (_value==5)
        {
        return true;
        }
        else
        {
            return false;
        }
    }
    public void Set(int value)
    {
        _value=value;
    }
    public int Get()
    {
         return _value;
    }
    

}
