using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RootofHnadle : MonoBehaviour
{
     AudioSource audiosource;�@//AudioSource�̕ϐ�
    [SerializeField] public AudioClip SE1; //�ԋʗp���ʉ�������Ƃ�
    [SerializeField] public AudioClip SE2; //�ʗp���ʉ�������Ƃ�

    public GameObject luckyEffect;

    // Start is called before the first frame update
    void Start()
    {
        //AudioSource���g����悤�ɂ���
        audiosource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    //�G���v�e�B�I�u�W�F�N�g�̃R���W�����ɍK�^�ʁE�s�^�ʂ��u�G�ꂽ�v���p
    private void OnCollisionEnter(Collision collision)
    {
        //�K�^�ʂɐG�ꂽ��K�^�ʂ������A����������SE���o�͂���(�I�u�W�F�N�gtag�Ŕ���)
        if (collision.gameObject.tag == "LuckyBall")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE1);

        }

        //�s�^�ʂ��G��Ă�����s�^�ʂ������āA����������SE���o�͂���(�I�u�W�F�N�gtag�Ŕ���)
        if (collision.gameObject.tag == "UnLuckyBall")
        {

            Destroy(collision.gameObject);

            audiosource.PlayOneShot(SE2);
        }
    }

}