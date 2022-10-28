using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 回転速度

    void Start()
    {
        // フレームレートを60に固定する
        Application.targetFrameRate = 60;
    }
    
    void Update()
    {
        // マウスが押されたら回転速度を設定する
        if(Input.GetMouseButtonDown(0) && this.rotSpeed < 0.1)
        {
            this.rotSpeed = 5;
        }
         // 回転速度ぶん、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        if(Input.GetMouseButtonDown(0) && this.rotSpeed == 5) {
            // ルーレットを減速させる（追加）
            this.rotSpeed *= 0.96f;
        }

       
    }
}
