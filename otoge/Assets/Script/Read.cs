using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using UnityEngine.SceneManagement;
public class Read : MonoBehaviour
{
    private StreamReader sr;
    public string filename;
    [SerializeField] private GameObject notes;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void yomitori()
    {
        sr = new StreamReader(Application.dataPath+"/Score/"+filename+".csv");
        while(!sr.EndOfStream)
        {//ç≈å„Ç‹Ç≈åJÇËï‘Ç∑

            string textline = sr.ReadLine();

            string[] a = textline.Split(',');
            
            if(int.Parse(a[2])==0)
            Instantiate(notes,
            new Vector2(float.Parse(a[1])+4, float.Parse(a[0])+4), 
            Quaternion.identity);
        }

        //Debug.Log(text);

    }

    // Update is called once per frame
    void Update()
    {
        //yomitori();
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("a");
            yomitori();
            sr.Close();
        }
        if(Input.GetKeyDown(KeyCode.X))
        SceneManager.LoadScene("tamesisiin");
    }

}
