using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorLV1StatsHolder : MonoBehaviour {


   
    public string IngameName;
    public int life;
    public int wut;
    public int basicattack;
    
    void Start ()
    {

        IngameName = "Warrior(Enemy)";
        life = 2000;
        wut = 500;
        basicattack = 100;
    }
}
