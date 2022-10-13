using System;
using System.IO;
using System.Linq;

class MyArray
{
    private int[] array;

	public int this[int index]
	{
		get { return array[index]; }
		set { array[index] = value; }	
	}

    public MyArray(int[] array)
    {
		this.array = array;
	}

    public MyArray(int size)
    {
        Random rnd = new Random();
		this.array = new int[size];
		for (int i = 0; i < size; i++)
		{
			array[i] = rnd.Next(-99, 100);
		}
    }

	public int Sum()
	{
		return array.Sum();
	}

    public void Inverse()
    {             
		for (int i = 0; i < array.Length; i++)
		{
			array[i] *= -1;			
        }          
    }

    public void Multi(int mlt)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= mlt;
        }
    }

    
    public int MaxCount()
    {
        int max = array.Max();
        int s = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
                s += 1;
        }
        return s;        
    }

    public MyArray(string fileName)
    {
        array = LoadArrayFromFileNumb(fileName);
    }

    public void PrintArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"{array[i]}\t"); 
        }
        Console.WriteLine();
    }

    private int[] LoadArrayFromFileNumb(string fileName)
	{
		if (File.Exists(fileName))
		{
			StreamReader sr = new StreamReader(fileName);
			int[] buf = new int[1000];
			int count = 0;
			while (!sr.EndOfStream)
			{
				buf[count] = int.Parse(sr.ReadLine());
				count++;
			}

			int[] arr = new int[count];
			Array.Copy(buf, arr, count);
			sr.Close();
			return arr;
		}
		else
			throw new FileNotFoundException();
	}

    public MyArray(int size,int startvalue, int step)
    {       
        array = new int[size];
        for (int i = 0; i < size; i++)
        {
			array[i] = startvalue;
			startvalue += step;
        }
    }    
}

