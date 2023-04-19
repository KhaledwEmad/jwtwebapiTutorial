namespace LoginITsupport
{
    public class User
    {
        public string username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }    

    }
}
