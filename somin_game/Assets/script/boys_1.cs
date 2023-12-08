using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boys_1 : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool wDown;
    bool leftshiftDown;

    Vector3 moveVec;

    Animator boys_ANIM;

    void Awake()
    {
        boys_ANIM = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("walk");
        leftshiftDown = Input.GetButton("run");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        if (wDown)
        {
            transform.position += moveVec * speed*0.3F* Time.deltaTime;

        }
        else
        {
            transform.position += moveVec * speed* Time.deltaTime; ;

            boys_ANIM.SetBool("walk", moveVec != Vector3.zero);
            boys_ANIM.SetBool("walk", wDown);

            transform.LookAt(transform.position + moveVec);
        }
        
        
    }
}
