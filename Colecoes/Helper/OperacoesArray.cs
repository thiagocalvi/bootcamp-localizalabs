namespace Colecoes.Helper
{
    public class OperacoesArray
    {

        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int n = 0; n < array.Length - 1; n++)
                {
                    if (array[n] > array[n+1] )
                    {
                        temp = array[n + 1];
                        array[n + 1] = array[n];
                        array[n] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
    }
}