public class Car
{
    public string Barand; //accessible from anywhere
    private int speed; // Accessible only within this class
    public void SetSpeed(int newSpeed)
    {

        if (newSpeed >= 0)
        {
            speed = newSpeed;
            Console.WriteLine("Speed adjusted : " + speed);
        }
        else
        {
            Console.WriteLine("Speed cannot be negative!");
        }

    }

}