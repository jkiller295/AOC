//Part 1
string[] input = File.ReadAllLines("input.txt");
long total = (from s in input 
                          let first = s.First(char.IsDigit).ToString() 
                          let last = s.Last(char.IsDigit).ToString() 
                          select long.Parse(first + last)).Sum();

//Part 2
string[] input = File.ReadAllLines("input.txt");

            Dictionary<string, string> numberDictionary = new Dictionary<string, string>
            {
                {"one","1"},
                {"two","2"},
                {"three","3"},
                {"four","4"},
                {"five","5"},
                {"six","6"},
                {"seven","7"},
                {"eight","8"},
                {"nine","9"}
            };

            long total = 0;
            foreach (string s in input)
            {
                string first = s.First(char.IsDigit).ToString();
                int firstIndex = s.IndexOf(first);
                string last = s.Last(char.IsDigit).ToString();
                int lastIndex = s.LastIndexOf(last);
                foreach (KeyValuePair<string, string> kvp in numberDictionary)
                {
                    int firstNumIndex = s.IndexOf(kvp.Key);
                    if (firstNumIndex > -1)
                    {
                        if (firstNumIndex < firstIndex)
                        {
                            firstIndex = firstNumIndex;
                            first = kvp.Value;
                        }
                    }
                    int lastNumIndex = s.LastIndexOf(kvp.Key);
                    if (lastNumIndex > -1)
                    {
                        if (lastNumIndex > lastIndex)
                        {
                            lastIndex = lastNumIndex;
                            last = kvp.Value;
                        }
                    }
                }
                total += long.Parse(first + last);
            }
