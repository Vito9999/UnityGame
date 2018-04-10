using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

public class Attack : MonoBehaviour { // Armor Reduce Art = Physic

    
    float PlayerRadius;
    public float AttackRange = 4f;

    public void HitArea(Vector2 center, float radius) //, int layerMask)
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius);
        int selected1 = 0;
        int PhysicArmorReduce = 90;//--------------ArmorReduce

        GameObject enemys = GameObject.Find("EnemyWorld1Holder");
        for (int i = 0; i < enemys.transform.childCount; i++)
        {

            for (int i1 = 0; i1 < enemys.transform.GetChild(i).childCount; i1++)
            {

                Select Select = enemys.transform.GetChild(i).GetChild(i1).GetComponent<Select>();
                Select.togglerend(false);
            }
        }
        for (int i = 0; i < hitColliders.Length; i++)
            {

                string a = hitColliders[i].name;
                GameObject enemystats = GameObject.Find(a);
                Select Select = enemystats.GetComponent<Select>();
                if (enemystats.GetComponent<Select>().selected == true)
                {
                    Select.togglerend(true);
                    selected1++;
                }
            }
            if (selected1 > 0 && Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < hitColliders.Length; i++)
                {
                    string a = hitColliders[i].name;
                    GameObject enemystats = GameObject.Find(a);
                    if (enemystats.GetComponent<Select>().selected == true)
                    {
                        Stats enemy = enemystats.GetComponent<Stats>();
                        
                    if(enemy.PhysicArmor - Mathf.RoundToInt(PhysicArmorReduce / selected1) <= 0)
                    {
                        enemy.PhysicArmor = 0;
                    }
                    else
                    {
                        enemy.PhysicArmor -= Mathf.RoundToInt(PhysicArmorReduce / selected1);
                    }
                    }
                }
            }
        
    }



     void Start()
    {
        PlayerRadius = this.transform.GetComponent<CircleCollider2D>().radius;
    }
     void FixedUpdate()
    {
        HitArea(this.transform.position, PlayerRadius + AttackRange); 
    }








}
