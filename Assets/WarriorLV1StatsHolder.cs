using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorLV1StatsHolder : MonoBehaviour {

    
     
   // public GameObject ThisObjectsName;
   
    public string IngameName;
    public int life;
    public int wut;
    public int basicattack;
    
    void Start ()
    {

        //ThisObjectsName = GameObject.Find("EnemyWorld1Holder");
        // WarriorLV1Stats = ThisObjectsName.GetComponent<WarriorLV1>();
        IngameName = "Warrior(Enemy)";
        life = 2000;
        wut = 500;
        basicattack = 100;
    }
}
