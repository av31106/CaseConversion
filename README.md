# CaseConversion
snake case to pascal and camel case conversion
  
        private static string CamelCase(string inputString)
        {
            /*Checking null and empty string.*/
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            var _charArray = inputString.ToCharArray();
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _charArray.Length; i++)
            {
                if (_charArray[i] == '_')
                    output.Append(_charArray[++i].ToString().ToUpper());
                else
                    output.Append(_charArray[i]);
            }
            return output.ToString();
        }

        private static string PascalCase(string inputString)
        {
            //Checking null and empty string.
            if (string.IsNullOrEmpty(inputString))
                return inputString;

            var _charArray = inputString.ToCharArray();
            StringBuilder output = new StringBuilder();
            if (_charArray.Length > 0)
            {
                _charArray[0] = _charArray[0].ToString().ToUpper().ToCharArray()[0];
                for (int i = 0; i < _charArray.Length; i++)
                {
                    if (_charArray[i] == '_')
                        output.Append(_charArray[++i].ToString().ToUpper());
                    else
                        output.Append(_charArray[i]);
                }
            }
            return output.ToString();
        }
