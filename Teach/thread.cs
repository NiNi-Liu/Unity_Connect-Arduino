using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Import Library
using System.Threading;

public class thread : MonoBehaviour
{
    [SerializeField]
    bool a = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Thread thr = new Thread(Function);
        thr.Start();
    }
    void Function()
    {
        if (a)
        {
            print("Hello");
            Thread.Sleep(1000);
        }
    }
    private void OnApplicationQuit()
    {
        //a = false;
    }
}
