﻿using System.Runtime.InteropServices.JavaScript;

namespace Greeter;

public static partial class JSInteropCallsContainer
{
    // this simple static method is exported to JavaScript
    // via WebAssembly
    [JSExport]
    public static string Greet(params string[] names)
    {
        var resultStr = string.Join(", ", names);

        // return a string greeting comma separated names passed to it
        // e.g. if the array of names contains two names "Joe" and "Jack"
        // then the resulting string will be "Hello Joe, Jack!!!".
        return $"Hello {resultStr}!!!";
    }
}

