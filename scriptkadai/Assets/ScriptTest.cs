using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // 配列を初期化する
        int[] points = { 20, 55, 121, 5, 92, 66, 36, 49 };

        for (int i = 0; i < points.Length; i++)
        {
                // 配列の要素を表示する
                Debug.Log(points[i]);
        }

        for (int i = 7; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(points[i]);
        }
        
        }
    }


