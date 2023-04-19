namespace ConsoleApp;

public class encrypt2 {
    public static string EncryptByKey(string message, string key)
    {
        try
        {
            var charCodes = new Dictionary<char, char>();
            for (int i = 0; i < key.Length; i++)
            {
                charCodes.Add(key[i], (char)(i + 65));
            }

            var encryptedChars = new List<char>();
            foreach (char c in message)
            {
                if (charCodes.TryGetValue(c, out char code))
                {
                    encryptedChars.Add(code);
                }
                else
                {
                    encryptedChars.Add(c);
                }
            }

            return new string(encryptedChars.ToArray());
        }
        catch 
        {
            Console.WriteLine("Не используйте два одинаковых символа для ключ-кода!");
                 
        }

        return null;
    }
}
