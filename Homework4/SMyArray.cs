using System;
using System.IO;

class SMyArray
{
    private string[] sarray;

    public string this[int index]
    {
        get { return sarray[index]; }
        private set { sarray[index] = value; }
    }

    public SMyArray(string[] array)
    {
        this.sarray = array;
    }

    public void PrintArray(string[] sarray)
    {
        for (int i = 0; i < sarray.Length; i++)
        {
            Console.WriteLine($"{sarray[i]}\t");
        }
        Console.WriteLine();
    }

    public SMyArray(string fileName)
    {
        sarray = LoadArrayFromFileString(fileName);
    }

    private string[] LoadArrayFromFileString(string fileName)
    {
        if (File.Exists(fileName))
        {
            StreamReader sr = new StreamReader(fileName);
            string[] buf = new string[1000];
            int count = 0;
            while (!sr.EndOfStream)
            {
                buf[count] = sr.ReadLine();
                count++;
            }

            string[] arr = new string[count];
            Array.Copy(buf, arr, count);
            sr.Close();
            return arr;
        }
        else
            throw new FileNotFoundException();
    }
}
