using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickersLastTime = new List<float>();
    public int autoclickerprice;

    private void Update()
    {
        for(int i = 0; i < autoClickersLastTime.Count; i++)
        {
            if(Time.time - autoClickersLastTime[i] >= 1.0f)
            {
                autoClickersLastTime[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        }
    }

    public void onbuyautoclicker()
    {
        if(GameManager.instance.gold >= autoclickerprice)
        {
            GameManager.instance.takegold(autoclickerprice);
            autoClickersLastTime.Add(Time.time);
        }
    }

}
