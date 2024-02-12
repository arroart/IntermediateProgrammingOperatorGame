using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Vector3 OGpos, NewPos;
    bool reachedNew, reachedOG;
    float heightDist = 0.5f;
    float startY;

    Ray ray;
    RaycastHit hit;

    Vector3 OGtransform;
    // Start is called before the first frame update

    void Start()
    {
        startY = transform.position.y;
        OGpos = transform.position;
        NewPos = new Vector3(transform.position.x, transform.position.y+0.5f, transform.position.z);
        OGtransform = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject== gameObject)
            {
                transform.localScale = OGtransform * 1.2f;
                //get the objects current position and put it in a variable so we can access it later with less code
                Vector3 pos = transform.position;
                //calculate what the new Y position will be
                float newY = startY + heightDist * Mathf.Sin(Time.time * moveSpeed);
                //set the object's Y to the new calculated Y
                transform.position = new Vector3(pos.x, newY, pos.z);
            }
            else
            {
                transform.position = OGpos;
                transform.localScale = OGtransform;
            }
            
        }
        

        if (transform.position != NewPos && !reachedNew)
        {

            //transform.position = Vector3.Lerp(OGpos, NewPos, moveSpeed);
        }
        //else
        //{
            //reachedNew = true;
        //}

        //if(transform.position != OGpos && reachedNew )
        //{
            //transform.position = Vector3.Lerp(NewPos, OGpos, moveSpeed);
        //}
        //else
        //{
            //reachedNew = false;
        //}
    }
  
}
