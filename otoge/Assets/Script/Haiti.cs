using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class Haiti : MonoBehaviour
{

    public int masu_x;  //譜面の横幅
    public int masu_y;  //譜面の縦幅

    private StreamReader sr;
    private int CountX= 0;
    private int CountY= 0;

    public TextAsset ScoreEdit = null;
    

    private int[,] masu;

    public GameObject square;
    private GameObject square1;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(ScoreEdit.name);
        //マスの指定した分ノーツエディターのシーンを生成する
        if (ScoreEdit == null)
        {
            Generate();
        }
        else
        {
            Reading();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        //情報更新
        if(Input.GetKeyDown(KeyCode.F5))
        {
            //譜面の一括消去
            GameObject[] a = GameObject.FindGameObjectsWithTag("notes");
            for(int i=0; i < a.Length; i++)
            {
                Destroy(a[i]);
            }

            //エディターの再生成
            if (ScoreEdit == null)
            {
                Generate();
            }
            else
            {
                
                Reading();
            }
        }
    }

    //譜面新規作成
    public void Generate()
    {
        masu = new int[masu_y, masu_x];
        for (int i = 0; i < masu.GetLength(0); i++)
        {
            for (int j = 0; j < masu.GetLength(1); j++)
            {
                Instantiate(square, new Vector2(j, i), Quaternion.identity);
            }
        }
    }

    //譜面の編集
    public void Reading()
    {
        //代入された譜面を呼び出す
        sr = new StreamReader(Application.dataPath + "/Score/" + ScoreEdit.name+".csv");
        while (!sr.EndOfStream)
        {//最後まで繰り返す

            string textline = sr.ReadLine();
            CountY++;
            string[] a = textline.Split(',');

            if (int.Parse(a[2]) == 0)
            {
                square1 = Instantiate(square,
                new Vector2(float.Parse(a[1]), float.Parse(a[0])),
                Quaternion.identity);
                square1.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 255);
            }
            else
            {
                square1 = Instantiate(square,
                new Vector2(float.Parse(a[1]), float.Parse(a[0])),
                Quaternion.identity);
                square1.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            }
            if(CountX<= int.Parse(a[1]))
            {
                CountX = int.Parse(a[1]);
            }
                        
        }
        CountX++;
        masu_y = CountY/CountX;
        masu_x = CountX;
        sr.Close();
    }
}
