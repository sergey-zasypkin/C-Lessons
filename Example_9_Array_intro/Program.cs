﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array = {13, 73, 84, 10, 7, 435, 478, 65, 100};

array[0] = 20;

Console.WriteLine(array[3]);
