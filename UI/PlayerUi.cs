using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 пространства имён UI и TMpro text
using UnityEngine.UI;
using TMPro;

public class PlayerUi : MonoBehaviour
{
    //Поле класса здоровья
    public Health health;
    // Поле класса монет
    public CoinsCounter coinsCounter;
    //Поле игрового объекта слайдер
    public Slider healthBar;
    // поле текста с количеством монет
    public TextMeshProUGUI coinsCounterText;
    //Поле скрипта игрока
    
    // Start is called before the first frame update
    void Start()
    {
        //Присваивание значений для ui
        healthBar.maxValue = health.maxhealth;
        healthBar.value = health.health;
        coinsCounterText.text = "coins:" + coinsCounter.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //Присваивание значений для ui
        healthBar.value = health.health;
        coinsCounterText.text = "coins:" + coinsCounter.coin;
    }
}
