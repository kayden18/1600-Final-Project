using System.Collections.Generic;
using System;
public class PowerLevels{
    private List<string> power;
    public void RunList(){
        power = new List<sting>();
        ChangeList();

    }
    private void ChangeList(){
        power.Add(Console.ReadLine());
        Console.WriteLine(power.Count);
        foreach(string p in power){
            Console.WriteLine(p);
        }
        ChangeList();
    }
}