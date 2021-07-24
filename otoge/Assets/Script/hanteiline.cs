using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class hanteiline : MonoBehaviour
{

    bool f1,f2,f3,f4 = false;
    //bool hureteru = false;

    void Start()
    {
        KeyConfig.Config["key1"] = KeyCode.D;
        KeyConfig.Config["key2"] = KeyCode.F;
        KeyConfig.Config["key3"] = KeyCode.J;
        KeyConfig.Config["key4"] = KeyCode.K;
    }

    public float judge = 0;
    public float  aaa= 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        //ÉLÅ[ê›íËÇé©óRÇ…Ç¢Ç∂ÇÍÇÈÇÊÇ§Ç…ÇµÇΩÇ¢ÇÊ
        if (KeyConfig.GetKeyDown("key1"))
        {
            StartCoroutine(Kesu(1));
        }
        if (KeyConfig.GetKeyDown("key2"))
        {
            StartCoroutine(Kesu(2));
        }
        if (KeyConfig.GetKeyDown("key3"))
        {
            StartCoroutine(Kesu(3));
        }
        if (KeyConfig.GetKeyDown("key4"))
        {
            StartCoroutine(Kesu(4));
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

       
            if(collision.gameObject.name== "notes(Clone)")
            {
                if(f1)
                if (collision.gameObject.transform.position.x == 4)
                {
                    judge += aaa;
                    Destroy(collision.gameObject);
                }
                if (f2)
                if (collision.gameObject.transform.position.x == 5)
                {
                    judge += aaa;
                    Destroy(collision.gameObject);
                }
                if (f3)
                if (collision.gameObject.transform.position.x == 6)
                {
                    judge += aaa;
                    Destroy(collision.gameObject);
                }
                if (f4)
                if (collision.gameObject.transform.position.x == 7)
                {
                    judge += aaa;
                    Destroy(collision.gameObject);
                }

            
            }

        
         
    }
    private void OnTrigger2D(Collider2D collision)
    {

    }

    IEnumerator Kesu(int i)
    {
        switch(i)
        {
            case 1:

                f1 = true;
                break;
            case 2:
                f2 = true;
                break;
            case 3:
                f3 = true;
                break;
            case 4:
                f4 = true;
                break;
            default:
                break;
        }
     

        yield  return new WaitForSeconds(0.02f);

        switch (i)
        {
            case 1:

                f1 = false;
                break;
            case 2:
                f2 = false;
                break;
            case 3:
                f3 = false;
                break;
            case 4:
                f4 = false;
                break;
            default:
                break;
        }
    }
    
}
