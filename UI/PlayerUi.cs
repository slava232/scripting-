using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 ������������ ��� UI � TMpro text
using UnityEngine.UI;
using TMPro;

public class PlayerUi : MonoBehaviour
{
    //���� ������ ��������
    public Health health;
    // ���� ������ �����
    public CoinsCounter coinsCounter;
    //���� �������� ������� �������
    public Slider healthBar;
    // ���� ������ � ����������� �����
    public TextMeshProUGUI coinsCounterText;
    //���� ������� ������
    
    // Start is called before the first frame update
    void Start()
    {
        //������������ �������� ��� ui
        healthBar.maxValue = health.maxhealth;
        healthBar.value = health.health;
        coinsCounterText.text = "coins:" + coinsCounter.coin;
    }

    // Update is called once per frame
    void Update()
    {
        //������������ �������� ��� ui
        healthBar.value = health.health;
        coinsCounterText.text = "coins:" + coinsCounter.coin;
    }
}
