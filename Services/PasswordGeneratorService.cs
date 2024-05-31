using System;
using System.Text;

public class PasswordGeneratorService
{
    private static readonly char[] _characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()".ToCharArray();

    public string GeneratePassword(int length)
    {
        if (length <= 0)
            throw new ArgumentException("Password length should be greater than 0", nameof(length));

        var password = new StringBuilder();
        var random = new Random();

        for (int i = 0; i < length; i++)
        {
            var index = random.Next(_characters.Length);
            password.Append(_characters[index]);
        }

        return password.ToString();
    }
}
