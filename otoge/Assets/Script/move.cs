using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float BPM;
    float pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(0, -0.02f*BPM/15, 0);
        pos = this.transform.position.y;

        if(pos<=0&&pos>=-5)
        {
           if(Input.GetKeyDown(KeyCode.Space))
                Destroy(this.gameObject);
            
            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        
        if(collision.collider)
        { 

        }
    }
}
