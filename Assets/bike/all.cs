using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class all : MonoBehaviour
{
    public int num;
    public static int flag_p;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        flag_p = num;
        Debug.Log("�����ꂽ!");  // ���O���o��
        Debug.Log(flag_p);
        SceneManager.LoadSceneAsync("Main");
    }

    public void set(int abcd)
    {
        num = abcd;
    }
}


