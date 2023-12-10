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
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic(int point)
    {
        if (mp >= point)
        {
            this.mp -= point;
            this.magicCount++;
            Debug.Log("残りMPは" + this.mp);

            
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
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