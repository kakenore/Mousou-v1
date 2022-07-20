using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class PlayerTurn : MonoBehaviour 
{          //���C���J�����i�[�p
    private GameObject playerObject;            //��]�̒��S�ƂȂ�v���C���[�i�[�p
    public float rotateSpeed = 2.0f;   //��]�̑���
    float tmp = 0;

    //�Ăяo�����Ɏ��s�����֐�
    void Start()
    {
        //���C���J�����ƃ��j�e�B���������ꂼ��擾
        //mainCamera = Camera.main.gameObject;
        playerObject = GameObject.Find("Player");
    }


    //�P�ʎ��Ԃ��ƂɎ��s�����֐�
    void Update()
    {
        //rotateCamera�̌Ăяo��
        rotateCamera();
    }

    //�J��������]������֐�
    private void rotateCamera()
    {
        //Vector3��X,Y�����̉�]�̓x�������`
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);
        tmp += Input.GetAxis("Mouse Y") * rotateSpeed;
        //transform.RotateAround()�����悤���ă��C���J��������]������
        transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        if (-90 < tmp && tmp < 90)
        {
        transform.RotateAround(playerObject.transform.position, transform.right, angle.y);
        }
        else if (tmp > 90)
        {
            tmp = 90;
        }else if(tmp < -90)
        {
            tmp = -90;
        }

    }
}