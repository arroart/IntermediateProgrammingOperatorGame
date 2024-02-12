using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var mousePos = Input.mousePosition;
        //Debug.Log(mousePos);
        //transform.LookAt(mousePos);

        var lookAtPos = Input.mousePosition;
        lookAtPos.z = 15f;
       
        lookAtPos = Camera.main.ScreenToWorldPoint(lookAtPos);

 
        lookAtPos.x = -lookAtPos.x;
        lookAtPos.y = -lookAtPos.y;


        transform.LookAt(lookAtPos);
       


        
    }
}
