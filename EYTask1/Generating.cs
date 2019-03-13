using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYTask1
{
    public class Generating
    {
        private static Random random = new Random();
        private const int fileNum = 100, lineNum = 100000;
        private const string eng_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string rus_chars = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";


        public static void Generator()
        {
            for (int i = 0; i < fileNum; i++)
            {
                using (StreamWriter bw = new StreamWriter(new FileStream(i + ".txt", FileMode.Create)))
                {
                    for (int j = 0; j < lineNum; j++)
                    {
                        DateTime start = new DateTime(2013, 1, 1);
                        int range = (DateTime.Today - start).Days;
                        DateTime randomDate = start.AddDays(random.Next(range));

                        string randomLatin = RandomString(10, eng_chars + eng_chars.ToLower());
                        string randomCyr = RandomString(10, rus_chars + rus_chars.ToLower());
                        int randomInt = random.Next(1, 100000001);
                        int r = random.Next(100000000, 2000000000);
                        double randomDouble = (double)r / 100000000.0;

                        //writing into the file
                        try
                        {
                            bw.WriteLine(randomDate.ToString("dd.MM.yyyy") + "||" + randomLatin + "||" + randomCyr + "||" + randomInt + "||" + randomDouble);
                        }
                        catch (IOException er)
                        {
                            MessageBox.Show(er.Message);
                            return;
                        }
                    }

                }

            }
        }

        //Making random string
        private static string RandomString(int length, string alpChars)
        {
            return new string(Enumerable.Repeat(alpChars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }    
}
