using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class boys : MonoBehaviour
{

    Animator boys_ANIM;
    private bool walk { get { return walk; } set { walk = value; boys_ANIM.SetBool("walk", value); } }  
    //값을 변경하면 애니메이터 값도 자동으로 변경되도록
    // 이거는 구글에서 긁어온거라 설명 들어야지 ㅠ
  
    // Start is called before the first frame update
    void Start()
    {
        boys_ANIM = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movez = 0f;
        float movex = 0f;
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            movez += 0.1f;
            boys_ANIM.SetBool("walk",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            movez += 0f;
            boys_ANIM.SetBool("walk", false);
        }
        // w 키에 대한 값
        //
        if (Input.GetKeyDown(KeyCode.S))
        {
            movez -= 0.1f;
            boys_ANIM.SetBool("walk",true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            movez -= 0f;
            boys_ANIM.SetBool("walk", false);
        }
        //S 키에 대한 값
        //
            if (Input.GetKeyDown(KeyCode.D))
        {
            movex += 0.1f;
            boys_ANIM.SetBool("walk", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            movez += 0f;
            boys_ANIM.SetBool("walk", false);
        }
        // D 키에 대한 값
        //
        if (Input.GetKeyDown(KeyCode.A))
        {
            movex -= 0.1f;
            boys_ANIM.SetBool("walk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            movez -= 0f;
            boys_ANIM.SetBool("walk", false);
        }
        // A 키에 대한 값
        //
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movez += 0.3f;
            boys_ANIM.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movez += 0f;
            boys_ANIM.SetBool("run", false);
        }
        //SHIFE에 대한 값
        //
        transform.Translate(new Vector3(movex, 0f, movez).normalized * 0.01f);

        // wasd 움직이는 키값
        // Normalized 정규화를 쓰는 이유가 궁금
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody>().AddForce(Vector3.up *100);

            boys_ANIM.SetBool("jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);

            boys_ANIM.SetBool("jump", false);
        }
        // 점프 키값 

    }
    }

