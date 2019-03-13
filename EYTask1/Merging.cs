using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EYTask1
{
    public class Merging
    {
        public static int counter = 0;

        public static void MergeFiles(string comb)
        {
            var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string[] txtFiles = Directory.GetFiles(path, "*.txt");

            using (StreamWriter writer = new StreamWriter("all.txt"))
            {
                for (int i = 0; i < txtFiles.Length; i++)
                {
                    if (!txtFiles[i].Contains("all.txt"))
                    {
                        using (StreamReader reader = File.OpenText(txtFiles[i]))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (comb != "" && line.Contains(comb))
                                {
                                    counter++;
                                    continue;
                                }
                                writer.WriteLine(line);
                            }
                        }
                        System.IO.File.Delete(txtFiles[i]);
                    }

                }
            }
        }
    }
}
