using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// �A�N�^�[����E����N���X
/// </summary>
public class ActorController : MonoBehaviour
{
    //�ϐ��錾
    // Start is called before the first frame update

    //Start (�I�u�W�F�N�g���s���ɂP�x�����s)
    void Start()
    {
        
    }

    // Update is called once per frame
    //Update�i�P�t���[�����ƂɂP�x�����s�j
    void Update()
    {
        //������
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        //��
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-50, 0);
        }
        //�E
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(50, 0);
        }
        //��
        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 50);
        }
        //��
        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -50);
        }
        /* //���̈ړ�����
         if(Input.GetKey(KeyCode.D))
         {//�E�����̈ړ�����
             Vector2 pos = transform.position;
             pos.x += 0.5f;
             transform.position = pos;

         }
         else if (Input.GetKey(KeyCode.A))
         {//�������̈ړ�����
             Vector2 pos = transform.position;
             pos.x -= 0.5f;
             transform.position = pos;
         }
         else if (Input.GetKey(KeyCode.W))
         {//������ւ̈ړ�
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
