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

    public void Damage ()
    {
        curHP--;

        healthBarFill.fillAmount = (float)curHP / (float)maxHp;

        if (curHP <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        Debug.Log("Defeated");
    }

}
