using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
public class kakidasi : MonoBehaviour
{

    private StreamWriter sw1,sw2;//ストリームライター使う宣言
    private GameObject[,] note;//書き出す用の配列
    private GameObject[,] sort; 
    [SerializeField] private GameObject Script;//xy取得用
    int Count=0;
    public string filename;
    // Start is called before the first frame update
    void Start()
    {
        note = new GameObject[Script.GetComponent<Haiti>().masu_y+1, Script.GetComponent<Haiti>().masu_x];
        //取得したxyと同じサイズの配列

        sw1 = new StreamWriter(Application.dataPath+"/mitame.csv", false);
        sw2 = new StreamWriter(Application.dataPath + "/"+filename+".csv", false);
        //Assetsの中にtamesi.csvを作る trueなら追記
        
        string[] s1 = { "x", "y", "aaa" };

        string s2 = string.Join(",", s1);
        //sw.WriteLine(s2);
    }

    public void SaveData1(string txt)//(string txt1, string txt2, string txt3)
    {
        string s1 = txt+",";// { txt1, txt2, txt3 };
        string s2 = string.Join(",", s1);

        sw1.Write(s1);
     
        
        //sw.WriteLine(s2);
    }

    public void SaveData2(string txt1, string txt2, string txt3)
    {
        string[] s1 ={ txt1, txt2, txt3 };
        string s2 = string.Join(",", s1);

        //sw2.Write(s1);
        sw2.WriteLine(s2);
    }
    private void Sort()
    {
        //Debug.Log("nu");


        GameObject[] a = GameObject.FindGameObjectsWithTag("notes");
        Debug.Log(a.Length);

        for (int i = 0; i < a.Length - 1; i++)
        {
            note[(int)a[i].transform.position.y, (int)a[i].transform.position.x] = a[i];
            //ざっくりいうと整理
        }
    }
    public void Mitame()
    {
        for(int i=note.GetLength(0)-1; 0<=i;i--)
        {//上下逆に書きたくて
            for (int j = 0; j < note.GetLength(1); j++)
            {
                //SaveData("a", "i", "u");



                if (note[i, j] == null)
                {

                }
                else if (note[i, j].GetComponent<Renderer>().material.color.g == 0)
                    SaveData1("1");//参照した奴が赤なら1を返す
                else
                    SaveData1("0");

                

                //Count++;
                //Debug.Log(Count);
            }
            sw1.WriteLine();
           //書き込んで改行
        }


        
    }
    public void Humen()
    {
        for (int i = 0; i < note.GetLength(0); i++)
        {
            for (int j = 0; j < note.GetLength(1); j++)
            {
                if (note[i, j] == null)
                {

                }
                else
                SaveData2(note[i, j].transform.position.y.ToString(),
                note[i, j].transform.position.x.ToString(), 
                note[i, j].GetComponent<Renderer>().material.color.g.ToString());
            }
        }
    }
    // Update is called once per frame
    void Update()
    {


        //Debug.Log("nu");
        if (Input.GetKeyDown(KeyCode.Z))
        {

            Sort();
            Mitame();
            Humen();
            sw1.Close();
            sw2.Close();
            /*
            for (int i = 0; i < Script.GetComponent<Haiti>().masu_y - 1; i++)
            {
                for (int j = 0; j < Script.GetComponent<Haiti>().masu_x - 1; j++)
                {
                    
                }
            }
            */

            //Debug.Log(note[0, 3].GetComponent<Renderer>().material.color.g);
            /*
            Debug.Log(a[a.Length-1].transform.position.x - 0.5 );
            Debug.Log(a[a.Length - 1].transform.position.y - 0.5);
            Debug.Log(a[a.Length - 1].GetComponent<Renderer>().material.color.g);
            */
        }

        //if(Input.GetKeyDown(KeyCode.X))
        //{
        //    Kaku();
        //}

        //if(Input.GetKeyDown(KeyCode.C))
        //{
        //    //Debug.Log()
        //    sw1.Close();
        //}
    }
}
