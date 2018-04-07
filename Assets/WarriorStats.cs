using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorStats : MonoBehaviour {


    public GameObject enemy;
    public WarriorLV1Stats wa;
	// Use this for initialization
	void Start ()
    {
        wa = enemy.GetComponent<WarriorLV1Stats>();
        string IngameName = wa.IngameName;
        int life = wa.life;
        int basicattack = wa.basicattack;
        int wut = wa.wut;
        
    }
        
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
