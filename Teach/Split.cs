using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    string data = "11,22!33+44=55";
    // Start is called before the first frame update
    void Start()
    {
        //定義容器
        string[] splitContain = data.Split(new char[] { ',', '!', '+', '=' }); //{"11","22","22","44","55"} 5


        for(int i = 0; i< splitContain.Length; i++)
        {
            print(splitContain[i]);
        }

        int x = 0;
        while (x < splitContain.Length)
        {
            print(splitContain[x]);
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


























    void mmm()
    {
        //Single
        string str = "John;Mary,Ken,peter;kevin";//字串data
        string[] ary = str.Split(';'); //定義string array容器，將分割後的data裝起來

        foreach (string i in ary)
        {
            print(i.ToString());
        }

        print("==============================================");

        //Multiple
        string str2 = "John;Mary,Ken,peter?kevin"; //字串data
        //char[] split_char = { ';', ',', '?' };
        //char[] split_char = new char[] { ';', ',', '?' };
        string[] ary2 = str2.Split(new char[] { ';', ',', '?' }); //定義string array容器，將分割後的data裝起來

        foreach (string i in ary2)
        {
            print(i.ToString());
        }
    }
}
