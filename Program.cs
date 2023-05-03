using System;



class Program

{
    static void Main(string[] args)
    {
        string sentence = "Це речення з багато пробілами між словами.  Тут є два пробіли підряд, але найбільше пробілів - це    чотири!";
        int maxSpacesInARow = 0;
        int spacesInARow = 0;
        foreach (char c in sentence)
        {
            if (c == ' ')
            {
                spacesInARow++;
            }

            else
            {
                if (spacesInARow > maxSpacesInARow)
                {
                    maxSpacesInARow = spacesInARow;
                }

                spacesInARow = 0;
            }
        }
        Console.WriteLine("Найбільша кількість пробілів, що розташовані підряд: " + maxSpacesInARow);
    }
}