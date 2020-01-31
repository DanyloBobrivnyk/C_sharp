namespace FunWithAttr
{
    public class UserContext
    {
        public string Role { get; }

        public UserContext(string role)
        {
            Role = role;
        }
    }
}