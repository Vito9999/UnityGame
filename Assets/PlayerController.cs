using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    private Rigidbody2D Rb2d;
    


    void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();
    
        
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(MoveHorizontal, MoveVertical);
        Rb2d.AddForce(movement * 10);

        
    }
   
    


}
