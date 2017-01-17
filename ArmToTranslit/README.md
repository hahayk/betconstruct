# Translate latin letters to armenian 
###The project demonstrates the usage of extention methods
By using this clas library you can convert latin letters to armenian. <br\>
In addition there are also some emotics shorcut converters to graphical ones. <br\>

Some code is below:
```C#
Dictionary<string, string> dic = new Dictionary<string, string>()
{
    //Alphabet
    {"a", "ա" }, {"A", "Ա" }, {"b", "բ" }, {"B", "Բ" },
    {"c", "ց" }, {"C", "Ց" }, {"d", "դ" }, {"D", "Դ" },
    {"e", "ե" }, {"E", "Ե" }, {"f", "ֆ" }, {"F", "Ֆ" },
	//...............
}

//...............

for (int i = 0; i < strSize; ++i)
{
    if ((i + 1) < strSize)
    {
        //Check for letters like gh-ղ, zh-ժ kh-խ ...
        curStr = str[i].ToString() + str[i + 1].ToString();
        if (dic.ContainsKey(curStr = str[i].ToString() + str[i + 1].ToString()))
        {
            retVal += dic[curStr];
            ++i;
        }
        //if there is no double letter check single ones
        else if (dic.ContainsKey(curStr = str[i].ToString()))
        {
            retVal += dic[curStr];
        }
        //if there are no any matching with dictionary
        //just write to output
        else
        {
            retVal += str[i].ToString();
        }
    }
   //...............
}

```

The result of the usage of lib is below: <br\>
![Translit Arm](/images/translit.gif)

<i>Extension methods enable you to "add" methods to existing types without creating a new derived type, 
recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, 
but they are called as if they were instance methods on the extended type. 
For client code written in C# and Visual Basic, there is no apparent difference between 
calling an extension method and the methods that are actually defined in a type. </i>

> This project written for .NET Framework 4.5.2 version, C#6