using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    public GameObject[] objects;
    SpriteRenderer rend;
    public Sprite[] sprites;
 
    void Start()
    {

        
        foreach (GameObject select in objects)
        {
            rend = select.GetComponent<SpriteRenderer>();
            rend.enabled = false;
            print(this.gameObject.name + "  selected: " + rend.enabled);
        }
    }

    public bool selected = false;
    public void OnMouseDown ()
    {
        selected = !selected;

        foreach (GameObject select in objects)
        {
            if (select.name == "select")
            { 
                rend.enabled = !rend.enabled;        
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
                   
                    rend.sprite = sprites[1]; //if gameobject is selected and is in the AttackArea
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
                rend.sprite = sprites[0]; // if gameobject is selected but isn't in the AttackArea
            }
            
            
        }
    }
    
   
    
}
