namespace Algoritmos;
public static class MoveZeroes
{
    //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //Note that you must do this in-place without making a copy of the array.

    public static Array Move(int[] array)
    {
        array = array.Where(x => x != 0).Concat(array.Where(x => x == 0)).ToArray();

        foreach(var i in array)
        {
            Console.Write(" - " + i );
        }
        Console.WriteLine();

        return array;
    }
}
