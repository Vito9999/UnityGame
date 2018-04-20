using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorLV1StatsHolder : MonoBehaviour {


   
    public string IngameName;
    public int life;
    public int wut;
    public int basicattack;
    public float MagicDamageReduction;
    public float PhysicDamageReduction;
    public int MagicArmor;
    public int PhysicArmor;

    void Start ()
    {

        IngameName = "Warrior(Enemy)";
        life = 2000;
        wut = 500;
        basicattack = 100;
        MagicDamageReduction = 0.9f;
        PhysicDamageReduction = 0.75f;
        MagicArmor = 50;
        PhysicArmor = 100;
    }
}
