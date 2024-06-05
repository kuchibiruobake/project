using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// アクター操作・制御クラス
/// </summary>
public class ActorController : MonoBehaviour
{
    //変数宣言
    // Start is called before the first frame update

    //Start (オブジェクト実行時に１度ずつ実行)
    void Start()
    {
        
    }

    // Update is called once per frame
    //Update（１フレームごとに１度ずつ実行）
    void Update()
    {
        //初期化
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //左
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-50, 0);
        }
        //右
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(50, 0);
        }
        //上
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 50);
        }
        //左
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -50);
        }
        /* //仮の移動処理
         if(Input.GetKey(KeyCode.D))
         {//右方向の移動入力
             Vector2 pos = transform.position;
             pos.x += 0.5f;
             transform.position = pos;

         }
         else if (Input.GetKey(KeyCode.A))
         {//左方向の移動入力
             Vector2 pos = transform.position;
             pos.x -= 0.5f;
             transform.position = pos;
         }
         else if (Input.GetKey(KeyCode.W))
         {//上方向への移動
             Vector2 pos = transform.position;
             pos.y += 0.5f;
             transform.position = pos;
         }
         else if(Input.GetKey(KeyCode.S))
         {
             Vector2 pos = transform.position;
             pos.y -= 0.5f;
             transform.position = pos;
         }*/
    }
   
}
