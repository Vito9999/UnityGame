using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    private Rigidbody2D Rb2d;

    private Vector3 actpos;

    void Start()
    {
        Rb2d = GetComponent<Rigidbody2D>();
        actpos = this.transform.position;
        
    }

    void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");
        actpos.x += MoveHorizontal;
        actpos.y += MoveVertical;
        this.transform.SetPositionAndRotation(actpos, new Quaternion(0, 0, 0, 0));

    }
   
    


}
