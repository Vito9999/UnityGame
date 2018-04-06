using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats_01 : MonoBehaviour {

    class warriorstats 
        {
        public int life;
        public string name;
        public int basicattack;
    }
    EnemyStats WarriorStats = new EnemyStats();
   
	// Use this for initialization
	void Start () {

        print(WarriorStats.warriorLV1.life+"SSSSSSSSSSSSS");
        WarriorStats.warriorLV1.name = "WarriorLv1___";
        WarriorStats.warriorLV1.basicattack = 20;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
