using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haiti : MonoBehaviour
{

    public int masu_y,masu_x;
    private int[,] masu;

    public GameObject sikaku;
    // Start is called before the first frame update
    void Start()
    {
        masu= new int[masu_y,masu_x];
        for(int i=0;i<masu.GetLength(0);i++)
        {
            for (int j = 0; j < masu.GetLength(1); j++)
            {
                Instantiate(sikaku, new Vector2(j, i ), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
