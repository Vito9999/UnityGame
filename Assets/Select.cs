using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    public GameObject[] objects;
    SpriteRenderer rend;
    public Sprite[] sprites;
    public bool inRange = false;
    /*public class enemie
    {
      
    }
    enemie E1 = new enemie();*/
    private void Start()
    {

        
        foreach (GameObject select in objects)
        {
            rend = select.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = false;
            print(this.gameObject.name + "  selected: " + rend.enabled);
        }
    }

    public bool selected = false;
    // Update is called once per frame
    public void OnMouseDown ()
    {
        selected = !selected;

        foreach (GameObject select in objects)
        {
            if (select.name == "select")
            {
               
                rend.enabled = !rend.enabled;
                rend.sprite = sprites[0];
               
            }
         
            

        }
        print(this.gameObject.name + "  selected: " + selected);
        
        
            
        
    }

   


    public void togglerend(bool dorend)
    {
        if (selected == true && dorend == true)
        {
            foreach (GameObject select in objects)
            {
                if (select.name == "select")
                {
                   
                    rend.sprite = sprites[1];
                    rend.enabled = dorend;
                }

            }
        }
        else {
            if(selected != true)
            {
                rend.enabled = selected;
            }
            if(selected == true)
            {
                rend.sprite = sprites[0];
            }
            
            
        }
    }
    
   
    
}
