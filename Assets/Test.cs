using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    //mp
    private int mp = 53;

    //魔法攻撃
    public void Magic()
    {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
    }
}



public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = {10, 100, 30, 70, 50};

        //順番
        for (int i = 0; i < array.Length; i++ )
        {
            Debug.Log(array[i]);
        }

        //逆順
        for (int i = 4; i >= 0; i-- )
            {
            Debug.Log(array[i]);
            }

            //Magic関数の呼び出し
            Boss midboss = new Boss();
        for (int i = 0; i <= 10; i++)
            midboss.Magic();
    }

    void Update()
    {

    }
}