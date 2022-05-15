class Program
{
    static void Write_Files(string[] s)
    {
        string[] Pathes = new string[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            using (StreamWriter writetext = new StreamWriter($"File.{i}.txt"))
            {
                writetext.WriteLine(s[i]);
                Pathes[i] = $"File.{i}.txt";
            }
        }

        Reverse_Files(s, Pathes);
    }

    static void Reverse_Files(string[] s, string[] Pathes)
    {
        string[] Path_to_Files = new string[s.Length];

        for (var i = 0; i < s.Length; i++)
        {
            char[] cArray = s[i].ToCharArray();
            string[] reverse = new string[s.Length];

            for (int j = cArray.Length - 1; j > -1; j--)
            {
                if (cArray[j] >= 'A' && cArray[j] < 'Z')
                {
                    reverse[i] += cArray[j-j];
                }
                else if (cArray[j] >= 'a' && cArray[j] < 'z' || cArray[j] == ' ')
                {
                    reverse[i] += cArray[j];
                }
            }

            using (StreamWriter writetext = new StreamWriter($"Changed_File.{i}.txt"))
            {
                Path_to_Files[i] = $"Changed_File.{i}.txt";
                writetext.WriteLine(reverse[i]);
                File.Delete(Pathes[i]);
            }
        }

        Read_Files(Path_to_Files);
    }

    static void Read_Files(string[] files)
    {
        foreach (var item in files)
        {
            using (StreamReader readtext = new StreamReader($"{item}"))
            {
                Console.WriteLine(readtext.ReadLine());
            }
        }
    }

    static void Main(string[] args)
    {
        string[] mockfiles = new string[3];
        for (int i = 0; i < 3; i++)
        {
            mockfiles[i] = Console.ReadLine();
        }
        Write_Files(mockfiles);
    }
}
