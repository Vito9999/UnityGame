using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

public class Attack : MonoBehaviour {

    //public class Player
    //{
    //    public bool hit;
    //    public int life;
    //    public Player(bool n_hit, int n_life)
    //        {
    //        hit = n_hit;
    //        life = n_life;
    //        }
    //}

    public List<GameObject> enemys;
   // public int[] a = new int[10];
   // public Transform[] aa;


    //Player myplayer = new Player(false, 100);
    public int c = 0, b = 0;

    private void Start()
    {
        print(enemys.Capacity.ToString());
        for (int i = 0; i < enemys.Capacity; i++)
        {


            foreach (var enemy in enemys)
            {
               
                var ab = enemy.transform.GetChild(0).name;
                
                print(ab.ToString());
                
            }
         
           

        }


        //print(myplayer.hit.ToString() + "  life: " + myplayer.life.ToString());
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))//Attack
        {
            foreach (var enemy in enemys)
            {
                // enemy.GetComponent<Select>().togglerend(!(Vector3.Distance(this.transform.position, enemy.transform.position) > 3.5f));
               

            }
            

            //if (myplayer.hit == true)
            //{
            //    myplayer.life -= 1;
            //    print(myplayer.life.ToString());
            //}else
            //{
            //    print("no damage");
            //}

        }

        

        
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
            
            
            var ab = enemy.transform.GetChild(b).GetChild(c).name;
            print(ab.ToString());
            var a = Vector3.Distance(this.transform.position, enemy.transform.GetChild(b).GetChild(c).position);
            
            
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
