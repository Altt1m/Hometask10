class User
{
    // Properties
    private string Name { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }

    // Static dictionary for registered users
    private static Dictionary<string, string> users = new Dictionary<string, string>();

    // Methods
    /// <summary>
    /// Registers new user
    /// </summary>
    /// <param name="username">Nickname or username</param>
    /// <param name="password">Password</param>
    public static void Register(string username, string password)
    {
        if (users.ContainsKey(username))
        {
            Console.WriteLine("User is already existing.");
        }
        else
        {
            users[username] = password;
            Console.WriteLine("User successfully registered.");
        }
    }

    /// <summary>
    /// Logins into the user's account
    /// </summary>
    /// <param name="username">Nickname or username</param>
    /// <param name="password">Password</param>
    public static void Login(string username, string password)
    {
        if (!users.ContainsKey(username))
        {
            Console.WriteLine("User not found. Do you want to register? (yes/no)");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                Register(username, password);
            }
            else
            {
                Console.WriteLine("User with this username is not registered.");
            }
        }
        else if (users[username] != password)
        {
            Console.WriteLine("Incorrect password.");
        }
        else
        {
            Console.WriteLine("Login successful.");
        }
    }
}
