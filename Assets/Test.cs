using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //MP初期化
   private int mp = 53;

    //魔法攻撃
   public void Magic()
    {
        //MPが足りるか確認
        if (mp >= 5)
        {
            //発動、のこりMP表示
            Debug.Log("魔法攻撃をした。のこりMPは" + mp+"。");
        }
        else
        {
            //発動不可表示
            Debug.Log("MPが足りないため魔法が使えない。");
        }

        //MPを5減少
        mp -= 5;
    }
}
public class Test : MonoBehaviour {

    
    // Use this for initialization
    void Start() {
        int[] array = { 3, 7, 4, 5, 8 };

        //順番に表示
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //逆順に表示
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        Boss lastboss = new Boss();

        //魔法使用
        lastboss.Magic();

        //魔法10回使用
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
    
        
    }

      
	
	// Update is called once per frame
	void Update () {
		
	}
}
