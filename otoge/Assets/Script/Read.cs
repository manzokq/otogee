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
    bool f = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void yomitori()
    {
        sr = new StreamReader(Application.dataPath+"/Score/"+filename+".csv");
<<<<<<< HEAD
=======
        while(!sr.EndOfStream)
        {//ç≈å„Ç‹Ç≈åJÇËï‘Ç∑
>>>>>>> origin/kasai

            Debug.Log("aaa");
        //if(!sr.EndOfStream)    
        //InvokeRepeating("Seisei", 0,1);
        

        //while(!sr.EndOfStream)
        //{//ç≈å„Ç‹Ç≈åJÇËï‘Ç∑
      
               
           /*
            string textline = sr.ReadLine();

            string[] a = textline.Split(',');
            
            if(int.Parse(a[2])==0)
            Instantiate(notes,
            new Vector2(float.Parse(a[1])+4, float.Parse(a[0])+4), 
            Quaternion.identity);
        */
        //}
        
        //Debug.Log(text);
        
    }
    public void Seisei()
    {
        f = false;
        
        string textline = sr.ReadLine();
        string[] a = textline.Split(',');
        for (int i = 0; i < 4; i++)
        {
            //Debug.Log("ê∏êª");
            if (int.Parse(a[2]) == 0)
                Instantiate(notes,
                new Vector2(float.Parse(a[1]) + 4, float.Parse(a[0]) + 4),
                Quaternion.identity);
          
        }
        Invoke("F", 0.1f);
    }
    void F()
    {
        f = true;
    }

    // Update is called once per frame
    void Update()
    {
        //yomitori();
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("a");
            yomitori();
            F();
            //sr.Close();
        }

        if(f)
        {
            Seisei();

        }

        if (Input.GetKeyDown(KeyCode.X))
        SceneManager.LoadScene("tamesisiin");
    }

}
