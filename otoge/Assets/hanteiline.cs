using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hanteiline : MonoBehaviour
{

    bool f1,f2,f3,f4 = false;
    bool hureteru = false;


    public float judge = 0;
    public float  aaa= 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(Kesu(1));
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Kesu(2));
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            StartCoroutine(Kesu(3));
        }
        if (Input.GetKeyDown(KeyCode.K))
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
