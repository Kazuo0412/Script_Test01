using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int magicCount = 0;

    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }

    public void Magic(int point)
    {
        if (mp >= point)
        {
            this.mp -= point;
            this.magicCount++;
            Debug.Log("�c��MP��" + this.mp);

            
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
public class Test_BOSS : MonoBehaviour
    {
        void Start()
        {
            Boss lastboss = new Boss();
            lastboss.Attack();
            lastboss.Defence(3);
            lastboss.Magic(5);        
        }

        // Update is called once per frame
        void Update()
        {

        }
    }