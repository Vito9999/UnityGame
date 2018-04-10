using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    GameObject a;
    GameObject ThisObjectsName;
    public WarriorLV1StatsHolder WarriorLV1;

    public string IngameName;
    public int life;
    public int wut;
    public int basicattack;

    void InitWarriorLV1()
    { 

        ThisObjectsName = GameObject.Find("WarriorLV1Holder");
        WarriorLV1 = ThisObjectsName.GetComponent<WarriorLV1StatsHolder>();
        IngameName = WarriorLV1.IngameName;
        life = WarriorLV1.life;
        wut = WarriorLV1.wut;
        basicattack = WarriorLV1.basicattack;
    }


    void Start()
    {
       if(this.transform.parent.name == "WarriorLV1Holder")
        {
            InitWarriorLV1();
        }
       
    }


}
