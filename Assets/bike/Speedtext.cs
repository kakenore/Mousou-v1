using UnityEngine;
using UnityEngine.UI;

public class Speedtext : MonoBehaviour
{
    // UI Text�w��p
    public Text TextFrame;
    // �\������ϐ�
    GameObject Bike;
    idou script;
    // Use this for initialization
    void Start()
    {
        Bike = GameObject.Find("Bike"); //Unity�������I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = Bike.GetComponent<idou>(); //u
    }

    // Update is called once per frame
    void Update()
    {
        float frame = script.speed;
        TextFrame.text = string.Format("{0} km/h", frame*-1);
    }
}