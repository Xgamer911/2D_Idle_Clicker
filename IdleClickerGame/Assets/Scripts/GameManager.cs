using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldtext;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void addgold(int amount)
    {
        gold += amount;
        goldtext.text = "Gold: " + gold.ToString();
    }

}
