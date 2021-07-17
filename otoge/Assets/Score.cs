using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public GameObject[] hantei;
    public Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float score = 0;
        for (int i=0;i<hantei.Length;i++)
        {
            score += hantei[i].GetComponent<hanteiline>().judge;
        }

        text.text = score.ToString();

    }
}
