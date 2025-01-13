class Sample
{


    void Datatype()
    {
        bool b = true;

        //Numberic
        short sh = -32768;
        int i = 2147483647;
        long l = 12341L;
        float f = 123.45F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        //Char/Sting
        char c = 'A';
        string s = "Hello";

        if (s[1] == 'e') 
            b = true;
        else 
            b = false;

        //DateTime  2011 - 10 - 30 12:35
        DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

        //max, min
        int i2 = int.MaxValue;
        float f2 = float.MinValue;

        //기억해야 되는 detatype
        //bool, char, int, short
    }

}