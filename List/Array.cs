using System;
using System.Collections.Generic;
public class Array{
    public static void Main(){
        var data = Console.ReadLine();
        Console.WriteLine(data);
        
        string[] array = data.Split(',');
        foreach(var str in array) {
            Console.WriteLine(str);
        }
    }
}