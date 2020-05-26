using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class try_catch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            try
            {
                //執行的程式 ----->在try中會去偵測是否有error，當有error就會送到catch做調整，根據catch的內容
                string[] text = new string[2];// 0 , 1
                print(text[2]);
            }
            catch (System.Exception ex) // System.Exception ex 此變數---> 為原本系統送出的error訊息
            {
                //----------要甚麼形式debug? 要debug甚麼內容?----------

                //使用系統原本的訊息
                //Debug.LogWarning(ex.Message);//此為改成warning的形式(黃色驚嘆號) 使用系統原本的訊息
                //Debug.LogError(ex.Message);//此為改成warning的形式(黃色驚嘆號) 使用系統原本的訊息

                //使用自己自訂的內容
                //Debug.LogWarning("There was an error"); //此為改成warning的形式(黃色驚嘆號) 並且輸入自己自訂的內容
                Debug.LogError("尚未連接"); //此為改成error的形式(紅色驚嘆號) 並且輸入自己自訂的內容
            }
        }
    }
}
