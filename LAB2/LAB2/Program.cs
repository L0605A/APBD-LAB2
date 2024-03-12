static double avg(int[] arr)
{
    double avg = 0;
    double sum = 0;
    int amt = arr.Length;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    avg = sum / amt;

    return avg;
}

Console.WriteLine("Hello, World!");
//this is a change 1
//this is a change 2
//this is a change 3

int[] test = { 1, 2, 3 };

Console.WriteLine(avg(test));