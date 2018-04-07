using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageStats : MonoBehaviour {

    public GameObject enemy;
    public MageStatsLV1 wa;
    // Use this for initialization
    void Start()
    {
        wa = enemy.GetComponent<MageStatsLV1>();
        string IngameName = wa.IngameName;
        int life = wa.life;
        int basicattack = wa.basicattack;
        int wut = wa.mana;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
