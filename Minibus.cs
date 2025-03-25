public class Minibus
{

    private int speed;
    public int Speed
    {

        get { return speed; }
        set
        {
            if (value >= 0)
            {
                speed = value;
            }
            else
            {
                Console.WriteLine("Speed cannot be negative!");
            }

        }

    }
}