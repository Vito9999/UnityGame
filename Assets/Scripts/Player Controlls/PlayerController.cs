using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    private Vector3 actpos;

    void Start()
    {
        actpos = this.transform.position;
    }

    void FixedUpdate()
    {
        actpos.x += Input.GetAxis("Horizontal"); 
        actpos.y += Input.GetAxis("Vertical"); 
        this.transform.SetPositionAndRotation(actpos, new Quaternion(0, 0, 0, 0));
    }
   
    


}
