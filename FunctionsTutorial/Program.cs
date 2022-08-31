Console.WriteLine("Functions Tutorial");
//Function does not need to be in a Class.  That would be a Method.

TimesTable(9); //calling the function. Enter a number to assign to number variable and calculate.

int Multiply(int i, int j)
{
    return i * j;
}
                
void TimesTable(int number = 12) //doing = 12 as the DEFAULT value for number variable.
{
    if (number > 12 || number <= 0) //Adding an exception to throw when number is not in range using IF statement
    {
        throw new Exception("TimesTable requires an int 1 <= number <= 12");
    }
        for (int idx = 1; idx <= 12; idx++)
        {
            Console.WriteLine($"{idx} X {number} = {Multiply(idx, number)}");
                //used {Multiply(idx, number)} which assigned the idx, number value to the i & j variables
                //in the multiply function to do the multiplication. 
    }
}