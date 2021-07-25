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
        cam.orthographicSize = 5f;//カメラのサイズ
    }

    // Update is called once per frame
    void Update()
    {
        //拡大・縮小
        if (Input.GetKey(KeyCode.LeftControl))
        {
            cam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel"); 
            if(cam.orthographicSize <= 2)
            {
                cam.orthographicSize = 2;
            }
        }
        //左右移動
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.right * Input.GetAxis("Mouse ScrollWheel");
        }
        //上下移動
        else
        {
            transform.position += transform.up *1.5f* Input.GetAxis("Mouse ScrollWheel");
        }
    }
    
}
