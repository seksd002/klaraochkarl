public class UserSession
{
    public UserSession(string userName, string role)
    {
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        Role = role ?? throw new ArgumentNullException(nameof(role));
    }

    public string UserName { get; set; }
    public string Role { get; set; }
}