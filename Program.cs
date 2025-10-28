using System;

public class ArrayReverser
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Исходный массив:");
        foreach (int element in originalArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("\n");
        int[] reversedArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            reversedArray[i] = originalArray[originalArray.Length - 1 - i];
        }
        Console.WriteLine("Перевернутый массив:");
        foreach (int element in reversedArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}































































