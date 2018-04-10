using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageLV1StatsHolder : MonoBehaviour {

    public string IngameName;
    public int life;
    public int mana;
    public int basicattack;
    public float MagicDamageReduction;
    public float PhysicDamageReduction;
    public int MagicArmor;
    public int PhysicArmor;
    void Start()
    {

        IngameName = "Mage(Enemy)";
        life = 1000;
        mana = 1000;
        basicattack = 50;
        MagicDamageReduction = 0.75f;
        PhysicDamageReduction = 0.9f;
        MagicArmor = 100;
        PhysicArmor = 50;
    }
}
