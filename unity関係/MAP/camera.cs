using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject Actor;
    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ActorPos  = Actor.transform.position;
        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(ActorPos.x, ActorPos.y, -10);
    }
}
