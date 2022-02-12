using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSplit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str = "aaajbbbjccc";
        string[] sArray = str.Split('j');
        foreach (string i in sArray)
        {
            Debug.Log(i.ToString());
        }

        Debug.Log("++++++++++++++++++++++++++++++");

        string[] sArrayList = str.Split('-');
        foreach (string i in sArrayList)
        {
            Debug.Log(i.ToString());
        }

        // ��������
        //aaa
        //bbb
        //ccc
        //++++++++++++++++++++++++++++++
        //aaajbbbjccc

        //ע�⣺Split('j')�ǵ�����


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
