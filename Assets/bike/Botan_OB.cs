using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botan_OB : MonoBehaviour
{
    public GameObject Bike;
   // public GameObject item;
    private all spd;
    // �{�^���������ꂽ�ꍇ�A����Ăяo�����֐�
    public void OnClick()
    {
        spd = Bike.GetComponent<all>();
        spd.set(4);
        Debug.Log("4�����ꂽ!");  // ���O���o��
       // Debug.Log(Botan_all.flag_p);
        //SceneManager.LoadSceneAsync("Main");
    }
}