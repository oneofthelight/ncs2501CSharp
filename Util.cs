class Util
{
    public static void PrintTntArray(int[] intArray)
    {
        Console.Write("{");
        for (int i = 0; i < intArray.Length; i++)
        {
            if ( i != 0)
            {
                Console.Write(",");
            }
            Console.Write(intArray[i]);
        }
        Console.WriteLine("}");
    }
}