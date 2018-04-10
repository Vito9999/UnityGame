using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

public class Attack : MonoBehaviour {


    float PlayerRadius;
    public float AttackRange = 4f;
    
    public void HitArea(Vector2 center, float radius)
    {
        
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(center, radius);
        int damage = 60;
        int selected1 = 0;


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
                        enemy.life -= damage / selected1;
                    }
                }
            }
        
    }



     void Start()
    {
        PlayerRadius = this.transform.GetComponent<CircleCollider2D>().radius;
    }
     void Update()
    {
        HitArea(this.transform.position, PlayerRadius + AttackRange);
    }








}
