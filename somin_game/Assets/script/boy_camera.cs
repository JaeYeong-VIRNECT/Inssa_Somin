using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boy_camera : MonoBehaviour
{
    GameObject boy;
    // Start is called before the first frame update
    void Start()
    {
        boy = GameObject.Find("boy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        boy.transform.position.x, boy.transform.position.y+1, boy.transform.position.z+2);
    {   // 카메라 위치 값 , 더블을 float으로 봐꾸고 싶댱,,

    };
    }
}
