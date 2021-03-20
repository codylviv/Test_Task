namespace Algorithm
{
    public class RailFenceCipher
    {

        public string EncryptRail(string encryptText, int numberOfRails)
        {
            var marker = char.MinValue;
            if (string.IsNullOrEmpty(encryptText) || numberOfRails < 2)
            {
                return string.Empty;
            }

            var rail = new char[numberOfRails, encryptText.Length];

            int row = 0;
            int col = 0;
            bool moveDown = false;
            for (int i = 0; i < encryptText.Length; i++)
            {
                moveDown = row == 0 || row == numberOfRails - 1 ? !moveDown : moveDown;
                rail[row, col++] = encryptText[i];
                row = moveDown == true ? ++row : --row;
            }

            var result = string.Empty;
            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < encryptText.Length; j++)
                {
                    if (rail[i, j] != marker)
                    {
                        result += rail[i, j];
                    }

                }
            }

            return result;
        }

        public string DecryptRail(string decryptText, int numberOfRails)
        {
            if (string.IsNullOrEmpty(decryptText) || numberOfRails < 2)
            {
                return string.Empty;
            }
            char setMarker = char.MaxValue;
            char[,] rail = new char[numberOfRails, decryptText.Length];
            bool moveDown = false;
            int row = 0;
            int col = 0;

            for (int i = 0; i < decryptText.Length; i++)
            {
                if (row == 0)
                {
                    moveDown = true;
                }
                if (row == numberOfRails - 1)
                {
                    moveDown = false;
                }
                rail[row, col++] = setMarker;
                row = moveDown == true ? ++row : --row;

            }

            int index = 0;
            for (int i = 0; i < numberOfRails; i++)
            {
                for (int j = 0; j < decryptText.Length; j++)
                {
                    if (rail[i, j] == setMarker && index < decryptText.Length)
                    {
                        rail[i, j] = decryptText[index++];
                    }
                }
            }

            row = 0;
            col = 0;
            var result = string.Empty;
            for (int i = 0; i < decryptText.Length; i++)
            {
                if (row == 0)
                {
                    moveDown = true;
                }
                if (row == numberOfRails - 1)
                {
                    moveDown = false;
                }
                if (rail[row, col] != setMarker)
                {
                    result += rail[row, col++];
                }
                row = moveDown == true ? ++row : --row;
            }
            return result;
        }

    }
}
