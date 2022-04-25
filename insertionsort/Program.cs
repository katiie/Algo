// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sort with insertion sort algorithm");
InsertionSort();


static void InsertionSort()
{
    // generate a sorted array with duplicates 
    var input_part1 = Enumerable.Range(1, 5).ToArray().Reverse().Concat(new int[]{ 1});
    var input_part2 = Enumerable.Range(50, 8);
    var array = Enumerable.Range(20,10).Reverse().ToArray();
    array = array.Concat(input_part1).Concat(input_part2).ToArray();

    Console.WriteLine("Array length: {0}",array.Length);
    Console.WriteLine("Intial array elements: {0}", string.Join(",", array));
    var tempIndex = 1;
    var position = 0;

    while(tempIndex < array.Length)
    {
        var tempvalue = array[tempIndex];
        for(var i = position; i >= 0 ; i--)
        {
            if(array[i] > tempvalue)
            {
                array[position + 1] = array[i];
                position -= 1;
            }
            else
            {
                continue;
            }
        }

        array[position + 1] = tempvalue;
        tempIndex++;
        position = tempIndex - 1;
    }

    Console.WriteLine();
    Console.WriteLine("Final array elements: {0}", string.Join(",", array));
    Console.ReadLine();
}
