using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int curHP;
    public int maxHp;
    public int goldToGive;
    public Image healthBarFill;
    public Animation anim;

    public void Damage ()
    {
        curHP--;

        healthBarFill.fillAmount = (float)curHP / (float)maxHp;

        anim.Stop();
        anim.Play();

        if (curHP <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        GameManager.instance.addgold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);

    }

}
