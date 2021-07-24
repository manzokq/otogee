using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
public class Tamesi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StreamWriter sw = new StreamWriter(@"tamesi2.csv", false);

        sw.WriteLine("aaa");
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
