This is an adaptation of part of the open source .NET Core 
to get ValueTuples to work with .NET 3.5.

<br>

Dll download (all you need in your project): 
https://gitlab.com/HardlyDifficult/ValueTupleForDotNet3_5/raw/master/ValueTuple.dll

<br><br>

Example use case:

var tuple = ("Wow", 42, .001);

var name = tuple.Item1;

<br><br>

The original .NET source: 
https://github.com/dotnet/corefx/blob/master/src/System.ValueTuple/src/System/ValueTuple/ValueTuple.cs

<br><br>

Learn more at http://youtube.com/HardlyDifficult
<br>
Join us live at http://twitch.tv/HardlyDifficult 