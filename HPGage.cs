using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HPGage : MonoBehaviour
{
    [SerializeField] private Image healthImage;
    [SerializeField] private Image burnImage;

    public Image filledBar;// 現在のHPに対応するImageコンポーネント
    public Gradient gradient;// HPバーの色を決定するためのGradient
    public float duration = 0.5f; //揺れの継続時間(0.5秒でHPが減る)
    // public float strength = 20f; //ゲージが揺れる強さ   
    // public int vibrate = 100; //揺れの周波数(揺れの強度)を設定   
    public float debugDamageRate = 0.2f; //0.2だけHPが減る 
    public float currentRate = 1.0f; //現在のHPを代入

    //startしたらHPが満タンの状態
    public void Start()
    {
        SetGauge(1.0f);
    }

    //指定したパラメータまで動かすメゾット 
    public void SetGauge(float targetRate) //SetGaugeにはセットしたいパラメータのレートを指定
    {
        // DoTweenを連結して動かす(DOTweenは最初にされたDOTweenの処理が終わったら次のアニメーションを実行できるから面倒なifを使わなくていい) = ラムダ式
        healthImage
        .DOFillAmount(targetRate, duration) //targetRate(指定したレート) を duration(例：0.5f) だけ時間をかけて変化させるアニメーション
        .OnComplete(() =>
        {    
            burnImage
                .DOFillAmount(targetRate, duration*0.5f) //(緑ゲージの0.5倍の速度で)赤ゲージが減る
                .SetDelay(0.5f);    //アニメーション開始(healthImageが終わった(緑ゲージが減った)0.5秒後に)

        });

        // transform
        //     .DOShakePosition(duration*0.5f, //揺れの継続時間
        //     strength, //揺れの強さ
        //     vibrate); //揺れの周波数(揺れの強度)
       
        currentRate = targetRate; //TakeDamageで受けたダメージに対するHPを更新する
    }

    //ダメージを受けた時にHPを減らす(何割ダメージを受けたか)
    public void TakeDamage(float rate)
    {
        SetGauge(currentRate - rate);
    }

    public void Update()
    {
        filledBar.color = gradient.Evaluate(filledBar.fillAmount); // HPに応じてバーの色を変える
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(debugDamageRate);
        }
    }
}