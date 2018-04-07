using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

public class Attack : MonoBehaviour {

    

    public List<GameObject> enemys = new List<GameObject>();
    public List<GameObject> selectedEnemys = new List<GameObject>();
    string a; bool r = false;

    public int c = 0,c1 = 0, b = 0, b1 = 0;
    
    public void Addenemy(GameObject currentEnemy)
    {
        
        print(currentEnemy.name + "/////3333333");
        enemys.Add(currentEnemy);
    }
    public void Addenemy1(GameObject currentEnemy)
    {

        print(currentEnemy.name + "?????????");
        selectedEnemys.Add(currentEnemy);
    }
    public void RemoveEnemy1(GameObject currentEnemy)
    {

      //  print(currentEnemy.name + "?????????");
        selectedEnemys.Remove(currentEnemy);
    }



    void Start()
    {
        
        Addenemy(GameObject.Find("EnemyLv1Holder"));
        print(enemys.Count);
        for (int i = 0; i < enemys.Capacity; i++)
        {


            foreach (var enemy in enemys)
            {
               
                var ab = enemy.transform.GetChild(0).name;
                
                print(ab.ToString() + "----------");
                
            }
         
           

        }


    }
   

    void Update () {

        
        

            foreach (var enemy in enemys)
            {

                if (c1 == enemy.transform.GetChild(b1).childCount)
                {
                    c1 = 0;
                    b1++;
                }
                if (b1 == enemy.transform.childCount)
                {
                    b1 = 0;

                }
            r = false;
            a = enemy.transform.GetChild(b1).GetChild(c1).name;
            if (Vector3.Distance(this.transform.position, enemy.transform.GetChild(b1).GetChild(c1).transform.position) < 4f)
            {
                enemy.transform.GetChild(b1).GetChild(c1).GetComponent<Select>().togglerend(true);

                
                print(a);
                for (int i = 0; i < selectedEnemys.Count; i++)
                {
                    if (selectedEnemys[i].name == a)
                    {
                        r = true;
                    }
                }
                if (r == false)
                {
                    Addenemy1(GameObject.Find(a));
                }
                if (Input.GetKeyDown(KeyCode.Alpha1))//Attack
                {
                    enemy.transform.GetChild(b1).GetChild(c1).GetComponent<WarriorStats>().life--;
                }



            }
            else { enemy.transform.GetChild(b1).GetChild(c1).GetComponent<Select>().togglerend(false);  RemoveEnemy1(GameObject.Find(a)); }
                //enemy.transform.GetChild(b1).GetChild(c1).GetComponent<Select>().togglerend((Vector3.Distance(this.transform.position, enemy.transform.GetChild(b1).GetChild(c1).transform.position) < 4f));

                 c1++;
            }

        


            //if (myplayer.hit == true)
            //{
            //    myplayer.life -= 1;
            //    print(myplayer.life.ToString());
            //}else
            //{
            //    print("no damage");
            //}

        



        
        
            foreach (var enemy in enemys)
            {


                if (c == enemy.transform.GetChild(b).childCount)
                {
                    c = 0;
                    b++;
                }
                if (b == enemy.transform.childCount)
                {
                    b = 0;
                    
                }


                string ab = enemy.transform.GetChild(b).GetChild(c).name;
                print(ab.ToString());

                float a = Vector3.Distance(this.transform.position, enemy.transform.GetChild(b).GetChild(c).position);


                if (a < 3f)
                {
                    print("!!!!!!!!!!" + enemy.transform.GetChild(b).GetChild(c).name);
                }
                c++;
            }
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag =="enemie1")
    //    {
    //        myplayer.hit = true;
    //        print("in collision" + myplayer.hit.ToString());
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if(collision.tag == "enemie1")
    //    {
    //        myplayer.hit = false;
    //        print("in collusion" + myplayer.hit.ToString());
    //    }
    //}
}
