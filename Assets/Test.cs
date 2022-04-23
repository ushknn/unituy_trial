using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System.IO;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset textasset = new TextAsset(); //テキストファイルのデータを取得するインスタンスを作成
        textasset = Resources.Load("Test", typeof(TextAsset) )as TextAsset; //Resourcesフォルダから対象テキストを取得
        Debug.Log(textasset.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
