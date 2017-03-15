This is an adaptation of part of the open source .NET Core 
to get ValueTuples to work with .NET 3.5.

Example use case:
var tuple = ("Wow", 42, .001);
var name = tuple.Item1;

The original .NET source: 
https://github.com/dotnet/corefx/blob/master/src/System.ValueTuple/src/System/ValueTuple/ValueTuple.cs

Learn more at http://youtube.com/HardlyDifficult
Join us live at http://twitch.tv/HardlyDifficult 