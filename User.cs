public class User
{

    private string password;
    public string Password
    {
        set
        {
            password = value;
        }
    }

    public string Name
    {
        get;
        set;
    } = "Mahmut";
}