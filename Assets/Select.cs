using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    public GameObject[] objects;
    SpriteRenderer  rend;
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
    

    // Update is called once per frame
    private void OnMouseDown()
    {

        foreach (GameObject select in objects)
        {
            rend = select.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = !rend.enabled;

        }
        print(this.gameObject.name + "  selected: " + rend.enabled);
    }
       
  /*  public void togglerend(bool dorend)
    {
        foreach (GameObject select in objects)
        {
            rend = select.gameObject.GetComponent<SpriteRenderer>();
            rend.enabled = dorend;

        }
    }*/
    
   
    
}
