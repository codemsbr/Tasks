namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yol 1
            //Verilmiş array-ı tərsinə çevirib yeni array yaradın.
            //int[] myArray = { 12, 21, 9, 6, 5, 4, 3, 2 };
            //int startNumber = 0;

            //for (int i = myArray.Length - 1 , counter = 0; i > counter; i-- , counter++)
            //{
            //    startNumber = myArray[counter];
            //    myArray[counter] = myArray[i];
            //    myArray[i] = startNumber; 
            //}
            #endregion

            #region Yol 2
            int[] myArray = { 12, 21, 9, 6, 5, 4, 3, 2 };
            int[] newArray = new int[myArray.Length];

            for (int i = 0; i < myArray.Length;)
            {
                newArray[i] = myArray[myArray.Length - ++i];
            }
            #endregion

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}