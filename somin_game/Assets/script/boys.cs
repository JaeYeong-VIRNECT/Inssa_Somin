using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class boys : MonoBehaviour
{

    Animator boys_ANIM;
    private bool walk { get { return walk; } set { walk = value; boys_ANIM.SetBool("walk", value); } }  
    //���� �����ϸ� �ִϸ����� ���� �ڵ����� ����ǵ���
    // �̰Ŵ� ���ۿ��� �ܾ�°Ŷ� ���� ������ ��
  
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
        // w Ű�� ���� ��
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
        //S Ű�� ���� ��
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
        // D Ű�� ���� ��
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
        // A Ű�� ���� ��
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
        //SHIFE�� ���� ��
        //
        transform.Translate(new Vector3(movex, 0f, movez).normalized * 0.01f);

        // wasd �����̴� Ű��
        // Normalized ����ȭ�� ���� ������ �ñ�
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody>().AddForce(Vector3.up *100);

            boys_ANIM.SetBool("jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 100);

            boys_ANIM.SetBool("jump", false);
        }
        // ���� Ű�� 

    }
    }

