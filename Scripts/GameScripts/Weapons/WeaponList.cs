using System.Collections.Generic;
using System;
public class WeaponList{
    //list
    public List<String> listofWeapons;
    public void RunList(){
        listofWeapons = new List<string>();
        ChangeList();
    }
    private void ChangeList(){
        ConsoleApplication.WriteLine(listofWeapons.Count);
        foreach(string weapon in listofWeapons){
            Console.WriteLine(weapon.name + " is the name of your weapon.");
            Console.WriteLine(weapon.power + "is the power of your weapon.");
        }
        Weapon newWeapon = new Weapon();
        newWeapon.name = Console.ReadLine();
        listofWeapons.Add(newWeapon);
        ChangeList();
    }
}