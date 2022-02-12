using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestForeach : MonoBehaviour
{
    void Start()
    {
        GoTestForeach();
    }

    private void GoTestForeach()
    {
        Debug.Log("start foreach ������ı���");
        var array = new List<string>();
        foreach(var item in array)
        {
            Debug.Log(item);
        }

        //foreach����в����޸�ö�ٳ�Ա
        var array2 = new List<string> { "", "1", "2", "3" };
        foreach(var item in array2)
        {
            Debug.Log(item);
            array2.Remove("1");
            Debug.Log(item);
        }

    }

}
