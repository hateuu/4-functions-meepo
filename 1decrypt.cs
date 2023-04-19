namespace ConsoleApp;

public class decrypt1 {
    public static string DecryptByFrequencyAnalysis(string encryptedMessage, string key)
    {
        var charCodes = new Dictionary<string, char>();
        for (int i = 0; i < key.Length; i++)
        {
            charCodes.Add(i.ToString(), key[i]);
        }

        var encryptedChars = encryptedMessage.Split();
        var decryptedChars = new List<string>();
        foreach (var c in encryptedChars)
        {
            if (charCodes.TryGetValue(c, out char symbol))
            {
                decryptedChars.Add(symbol.ToString());
            }
            else
            {
                decryptedChars.Add(c);
            }
        }

        return string.Join("", decryptedChars);
    }
}