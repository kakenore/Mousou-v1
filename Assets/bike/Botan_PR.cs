using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_PR : MonoBehaviour
{
    public GameObject Bike;
   // public GameObject item;
    private all spd;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        spd = Bike.GetComponent<all>();
        spd.set(1);
        Debug.Log("1�����ꂽ!");  // ���O���o��
                              // Debug.Log(Botan_all.flag_p);
                              //SceneManager.LoadSceneAsync("Main");
    }
}