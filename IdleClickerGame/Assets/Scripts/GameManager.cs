using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldtext;

    public Sprite[] backgrounds;
    private int curbackground;
    private int enemiesuntilbackgroundchange;
    public Image backgroundimage;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemiesuntilbackgroundchange = 5;
    }

    public void addgold(int amount)
    {
        gold += amount;
        goldtext.text = "Gold: " + gold.ToString();
    }

    public void takegold(int amount)
    {
        gold -= amount;
        goldtext.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesuntilbackgroundchange--;

        if(enemiesuntilbackgroundchange==0)
        {
            enemiesuntilbackgroundchange = 5;
            curbackground++;

            if (curbackground == backgrounds.Length)
            {
                curbackground = 0;
            }

            backgroundimage.sprite = backgrounds[curbackground];
        }
    }
}
