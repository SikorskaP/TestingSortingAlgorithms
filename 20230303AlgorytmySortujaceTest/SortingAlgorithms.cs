namespace TestingSortingAlgorithms
{
    class SortingAlgorithms
    {
        public static int[] SelectionSort(int[] tab)
        {

            for (int i = 0; i < tab.Length; i++)
            {
                int value, min = i;

                for (int j = i + 1; j < tab.Length; j++)
                    if (tab[j] < tab[min]) min = j;

                value = tab[i];
                tab[i] = tab[min];
                tab[min] = value;
            }
            return tab;
        }

        public static void InsertionSort(int[] tab)
        {
            int j, v;
            for (int i = 1; i < tab.Length; i++)
            {
                j = i; v = tab[i];
                while (tab[j - 1] > v)
                {
                    tab[j] = tab[j - 1]; j -= 1;
                    if (j == 0) break;
                }
                tab[j] = v;

            }
        }

        public static void QuickSort(int[] tab, int low, int high)
        {
            int pivotElement = tab[(low + high) / 2];
            int i = low;
            int j = high;
            int value;

            do
            {
                while (tab[i] < pivotElement) i++;
                while (tab[j] > pivotElement) j--;
                if (i <= j)
                {
                    value = tab[i];
                    tab[i] = tab[j];
                    tab[j] = value;
                    j--; i++;
                }
            } while (i <= j);
            if (low < j) QuickSort(tab, low, j);
            if (high > i) QuickSort(tab, i, high);
        }
    }
}
