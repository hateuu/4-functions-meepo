        static string DecryptByKey(string encryptedMessage, string key)
        {
            var charCodes = new Dictionary<char, char>();
            for (int i = 0; i < key.Length; i++)
            {
                charCodes.Add((char)(i + 65), key[i]);
            }

            var decryptedChars = new List<char>();
            foreach (char c in encryptedMessage)
            {
                if (charCodes.TryGetValue(c, out char code))
                {
                    decryptedChars.Add(code);
                }
                else
                {
                    decryptedChars.Add(c);
                }
            }

            return new string(decryptedChars.ToArray());
        }