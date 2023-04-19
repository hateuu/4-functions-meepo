static string EncryptByFrequencyAnalysis(string message, string key)
        {

                try
                {
                    var charCodes = new Dictionary<char, string>();
                    for (int i = 0; i < key.Length; i++)
                    {
                        charCodes.Add(key[i], i.ToString());
                    }

                    var encryptedChars = new List<string>();
                    foreach (char c in message)
                    {
                        if (charCodes.TryGetValue(c, out string code))
                        {
                            encryptedChars.Add(code);
                        }
                        else
                        {
                            encryptedChars.Add(c.ToString());
                        }
                    }

                    return string.Join( , encryptedChars);
                }
                catch
                {
                    Console.WriteLine(Не используйте два одинаковых символа для ключ-кода!);
                }

            return null;
        } //Первый способ шифрования
