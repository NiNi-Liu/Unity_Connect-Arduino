using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==================
using System.IO.Ports;
//==================新的執行緒
using System.Threading;

public class arduino_myVersionV2 : MonoBehaviour //此版本FPS超高!! 很棒
{
    public string COM;
    SerialPort sp;
    [SerializeField]
    string readMessage;
    // Start is called before the first frame update
    void Start()
    {
        //連結Arduino的三步驟
        sp = new SerialPort(COM, 9600); //1.定義serial port
        sp.Open();                      //2.開啟SerialPort連線
        sp.ReadTimeout = 1000;          //3.超過1秒沒有讀取到內容時，就認為此次讀取不到內容。
        //進行非同步運算的執行緒
        Thread thr = new Thread(ReadArduinoData); //定義新的執行緒
        thr.Start(); //啟用新的執行緒
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ReadArduinoData()
    {
        while (sp.IsOpen)// 如果SerialPort連線成功--->讀取data
        {
            readMessage = sp.ReadLine();
            print(readMessage); //將data顯示出來
        }
    }

    void OnApplicationQuit()
    {
        //當應用程式結束時會自動呼叫這個函數
        sp.Close(); //關閉條件，使上方function跳出while迴圈  因為執行緒不會因為遊戲結束而結束，必須另外關掉
    }
}
