# Extension Methods.
##Polidrom string project

Polidrom strings are strings that are symmetric from the center of the string.
Some code snippet is below:
```C#
public static bool IsPolidromString(this string inputStr)
{
    var strSize = inputStr.Length - 1;

    for (int i = 0; i <= strSize; ++i)
    {
        if(inputStr[i] == inputStr[strSize - i])
        {
            continue;
        }
        else
        {
            return false;
        }
    }
            
    return true;
}
```

The result for given string AnnA it will return true.
The result for given string Hello it will return false. <br\>



<i>Extension methods enable you to "add" methods to existing types without creating a new derived type, 
recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, 
but they are called as if they were instance methods on the extended type. 
For client code written in C# and Visual Basic, there is no apparent difference between 
calling an extension method and the methods that are actually defined in a type. </i>

> This project written for .NET Framework 4.5.2 version, C#6