using System.Collections.Generic;

namespace ASafariM.Application.Utils
{
    public class UserUtilities
    {
        public static List<Guid> GenerateUserIdsFromBaseGuid(Guid baseGuid, int count)
        {
            List<Guid> userIds = new List<Guid>();
            byte[] baseBytes = baseGuid.ToByteArray();

            // Start with a completely different byte array to avoid conflicts
            byte[] newGuidBytes = new byte[16];
            for (int i = 0; i < 16; i++)
            {
                newGuidBytes[i] = (byte)(baseBytes[i] ^ 0xFF); // XOR with 0xFF to get complement
            }

            userIds.Add(new Guid(newGuidBytes));

            for (int i = 1; i < count; i++)
            {
                IncrementByteArray(newGuidBytes);
                userIds.Add(new Guid(newGuidBytes));
            }

            return userIds;
        }

        private static void IncrementByteArray(byte[] bytes)
        {
            for (int i = bytes.Length - 1; i >= 0; i--)
            {
                if (++bytes[i] != 0)
                {
                    break;
                }
            }
        }

        // Create a username from a given string like firstname
        public static string TransformFirstNameToUsername(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                return "";

            // Normalize the first name
            var replacements = new Dictionary<string, string>
            {
                { "-", " " },
                { "_", " " },
                { ".", "" },
                { "í", "i" },
                { "ó", "o" },
                { "ú", "u" },
                { "é", "e" },
                { "ä", "a" },
                { "ö", "o" },
                { "ü", "u" },
                { "&", "and" },
                { "@", "at" },
                { "#", "number" },
                { "$", "dollar" },
                { "%", "percent" },
                { "ç", "c" },
                { "ñ", "n" },
                { "ß", "ss" },
            };

            foreach (var replacement in replacements)
            {
                firstName = firstName.Replace(replacement.Key, replacement.Value);
            }

            // Replace spaces with underscores and convert to lower case
            firstName = firstName.Replace(" ", "_").ToLower();

            // Always add a random suffix to ensure uniqueness
            var randomSuffix = Guid.NewGuid().ToString().Substring(0, 4);
            return $"{firstName}_{randomSuffix}";
        }
    }
}
