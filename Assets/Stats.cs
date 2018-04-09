using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    GameObject a;
    GameObject ThisObjectsName;
    public WarriorLV1StatsHolder Warrior;
    public string IngameName;


    void WarriorLV1()
    { 

        ThisObjectsName = GameObject.Find("WarriorLV1Holder");
        Warrior = ThisObjectsName.GetComponent<WarriorLV1StatsHolder>();
        IngameName = Warrior.IngameName;
    }


    void Start()
    {
       if(this.transform.parent.name == "WarriorLV1Holder")
        {
            WarriorLV1();
        }
       
    }


}
