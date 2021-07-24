using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sikaku : MonoBehaviour
{


    bool f = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Renderer>().material.color.g==0)
        {
            f = false;
        }
        else if(GetComponent<Renderer>().material.color.g==1)
        {
            f = true;
        }
    }

    private void OnMouseDown()
    {
        if(f)
        GetComponent<Renderer>().material.color = new Color32(255, 0, 0,255);
        else if(!f)
        GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);


        //Debug.Log(transform.position.y);
        //Debug.Log(transform.position.x);
    }
}
