using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    GameObject EnemyHolder;
    WarriorLV1StatsHolder WarriorLV1;
    MageLV1StatsHolder MageLV1;

    public float  PhysicDamageReduction;
    public float  MagicDamageReduction;
    public string IngameName;
    public int life;
    public int mana;
    public int basicattack;
    public int wut;
    public int MagicArmor;
    public int PhysicArmor;
    void InitWarriorLV1()
    {

        EnemyHolder = GameObject.Find("WarriorLV1Holder");
        WarriorLV1 = EnemyHolder.GetComponent<WarriorLV1StatsHolder>();
        IngameName = WarriorLV1.IngameName;
        life = WarriorLV1.life;
        wut = WarriorLV1.wut;
        basicattack = WarriorLV1.basicattack;
        MagicDamageReduction = WarriorLV1.MagicDamageReduction;
        PhysicDamageReduction = WarriorLV1.PhysicDamageReduction;
        MagicArmor = WarriorLV1.MagicArmor;
        PhysicArmor = WarriorLV1.PhysicArmor;
    }
    void InitMageLV1()
    {

        EnemyHolder = GameObject.Find("MageLV1Holder");
        MageLV1 = EnemyHolder.GetComponent<MageLV1StatsHolder>();
        IngameName = MageLV1.IngameName;
        life = MageLV1.life;
        mana = MageLV1.mana;
        basicattack = MageLV1.basicattack;
        MagicDamageReduction = MageLV1.MagicDamageReduction;
        PhysicDamageReduction = MageLV1.PhysicDamageReduction;
        MagicArmor = MageLV1.MagicArmor;
        PhysicArmor = MageLV1.PhysicArmor;
    }


    void Start()
    {
        if (this.transform.parent.name == "WarriorLV1Holder")
        {
            InitWarriorLV1();
        }
        if (this.transform.parent.name == "MageLV1Holder")
        {
            InitMageLV1();
        }

    }
    void Update()
    {
        
    }


}
