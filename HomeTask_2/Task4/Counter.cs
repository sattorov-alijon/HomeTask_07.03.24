namespace Task4;

public class Counter
{
    public int _value;
    public Counter(int startValue)
    {
        _value = startValue;
    }
    public Counter()
    {
        _value = 0;
    }
    public int Get()
    {
        return _value;
    }


    public void Increase()
    {

        _value++;

    }
    public void Decrease()
    {
        if (_value > 0)
        {
            _value--;
        }
    }
    public void Increase(int increaseBy)
    {
        if (increaseBy > 0)
        {
            _value += increaseBy;
        }
    }
    public void Decrease(int decreaseBy)
    {
        if (decreaseBy > 0)
        {
            _value -= decreaseBy;
        }
    }
}
