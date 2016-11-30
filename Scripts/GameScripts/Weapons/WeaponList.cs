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
            Console.WriteLine(weapon.name);
        }
        Weapon newWeapon = new Weapon();
        listofWeapons.Add(newWeapon);
        ChangeList();
    }