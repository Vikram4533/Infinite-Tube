using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {

    float dragDistance;
    Vector3 fp;
    Vector3 lp;

    public float timec = -1.5707f;
    float speed = 4f;
    float height = 1.35f;
    float width = 1.35f;
    float z = 0;
    float x = 0;
    float y = 0;
    float insp = 0.10f;

    float yror;
    float xror;
    Vector3 vik;
    public Vector3 final;
    Rigidbody rb;

    /////////////
	void Start(){
        
        dragDistance = Screen.height * 0.10f / 100;
     
    }
    /////////////
    
    ////////////////////
    void FixedUpdate()
    {
        movements();
    }

    
    void movements()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;

                if (Mathf.Abs(lp.x - fp.x) > dragDistance)
                {
                    if ((lp.x > fp.x))
                    {
                        timec = timec + Time.deltaTime * speed;
                        x = Mathf.Cos(timec) * width;
                        y = Mathf.Sin(timec) * height;
                        transform.position = new Vector3(x, y, z);
                        fp = lp;
                    }
                    else
                    {
                        timec = timec - Time.deltaTime * speed;
                        x = Mathf.Sin(timec) * width;
                        y = Mathf.Cos(timec) * height;
                        transform.position = new Vector3(y, x, z);
                        fp = lp;
                    }
                }
                else
                {
                    fp = lp;
                }
            }
        }
      
        x = Mathf.Cos(timec) * width;
        y = Mathf.Sin(timec) * height;
        transform.position  = new Vector3(x, y, z);
        gameObject.transform.Rotate(10, 0, 0);
        z = z + insp;
    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            Destroy(gameObject);
        }
    }

}







