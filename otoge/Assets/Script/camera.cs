using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private GameObject came = null;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        came = GameObject.Find("Main Camera");
        cam = came.GetComponent<Camera>();
        cam.orthographicSize = 5f;//�J�����̃T�C�Y
    }

    // Update is called once per frame
    void Update()
    {
        //�g��E�k��
        if (Input.GetKey(KeyCode.LeftControl))
        {
            cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel"); 
            if(cam.orthographicSize <= 2)
            {
                cam.orthographicSize = 2;
            }
        }
        //���E�ړ�
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.right * Input.GetAxis("Mouse ScrollWheel");
        }
        //�㉺�ړ�
        else
        {
            transform.position += transform.up *1.5f* Input.GetAxis("Mouse ScrollWheel");
        }
    }
    
}
