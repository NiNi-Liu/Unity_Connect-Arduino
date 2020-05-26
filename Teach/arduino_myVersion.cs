using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//==================
using System.IO.Ports;

public class arduino_myVersion : MonoBehaviour //此版本FPS超低!!! 非常不理想
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
    }

    // Update is called once per frame
    void Update()
    {
        ReadArduinoData(); //執行讀取serialPort Function

        print(readMessage); //將data顯示出來
    }

    void ReadArduinoData()
    {
        if (sp.IsOpen) // 如果SerialPort連線成功--->讀取data
        {
            readMessage = sp.ReadLine();
        }
    }
}
