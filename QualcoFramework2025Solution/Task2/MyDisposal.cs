using System;
using System.IO;

namespace QualcoLab2025.Task2
{

    public class MyDisposal
    {
        public void SaveToFileOld(string filePath, string content)
        {

            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(content);
            writer.Close();
        }

        
    }
}