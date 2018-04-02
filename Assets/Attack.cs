using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

public class Attack : MonoBehaviour {

    public class Player
    {
        public bool hit;
        public int life;
        public Player(bool n_hit, int n_life)
            {
            hit = n_hit;
            life = n_life;
            }
    }

    Player myplayer = new Player(false, 100);


    private void Start()
    {
        print(myplayer.hit.ToString() + "  life: " + myplayer.life.ToString());
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (myplayer.hit == true)
            {
                myplayer.life -= 1;
                print(myplayer.life.ToString());
            }else
            {
                print("no damage");
            }

        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag =="enemie1")
        {
            myplayer.hit = true;
            print("in collision" + myplayer.hit.ToString());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "enemie1")
        {
            myplayer.hit = false;
            print("in collusion" + myplayer.hit.ToString());
        }
    }
}
