namespace Algoritmos;
public static class TwoSum
{
    //Given an array of integers nums and and integer target, return the indices of the two numbers such that they add up to target.

    //You may assume that each input would have exactly one solution, and you may not use the same element twice.


    public static Array Sum(int[] array, int target)
    {
        var index = 0;
        var result = new int[2];
        do
        {
            var value = array[index];
            var indexTargetToSum = Array.FindIndex(array, index + 1, x => x + value == target);

            if(indexTargetToSum != -1)
            {
                Console.WriteLine($"[{index}, {indexTargetToSum}]");
                result[0] = index;
                result[1] = indexTargetToSum;
                break;
            }
            index++;
        } while (index < array.Length);

        return result;
    }
}
