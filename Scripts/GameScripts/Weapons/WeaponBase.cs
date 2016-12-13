using System;
public class WeaponBase
{
    public int power = 10;
    public float range = 1.0f;
    public int ammoCount = 100;
    public void Fire(){
        for (int i = ammoCount; i > 0 ; i--){
            ammoCount--;
            Console.WriteLine("Fire" + ammoCount);
        }}
    public void SemiAutoFire (){
        int i = ammoCount;
        while(i > 0){
            ammoCount--;
            Game.GameTimer();
            Console.WriteLine("Fire" + ammoCount);
        }
    }
    }