using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {


    public class EnemyStaatsLV1
    {
        public int life;
        public string name;
        public int basicattack;
    }
    public List<GameObject> enemys;
    public Transform[] aa;
    
    

	// Use this for initialization
	void Start () {
        for (int i = 0; i < enemys.Capacity; i++)
        {
            aa[i] = this.transform.GetChild(i);

        }

        foreach (var enemy in enemys)
        {
            int i = 0;
            var a = Vector3.Distance(this.transform.position, enemy.transform.GetChild(i).position);
            i++;
            if (a < 3f)
            {
                print(enemy.name);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
