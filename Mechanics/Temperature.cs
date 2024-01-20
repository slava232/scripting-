using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{
    private float currentTemp = 36.6f;
    public float maxTemp = 36.6f;
    public float minTemp = 34.4f;
    public TextMeshProUGUI tempText;
    public int damage = 2;
    public float delay = 2;
    public float freezeSpeed = 0.05f;
    // Update is called once per frame
    void Update()
    {
        currentTemp -= freezeSpeed * Time.deltaTime;
        tempText.text = System.MathF.Round(currentTemp,2).ToString();
        if (currentTemp <= minTemp)
        {
            delay -= Time.deltaTime;
            if (delay <= 0) {
                print("Проверь темпу");
                gameObject.GetComponent<Health>().TakeDamage(damage);
                delay = 2;
            }
           
        }
    }

    public void TemperatureUp(float temp)
    {
        if (currentTemp < maxTemp)
        {
            currentTemp += temp * Time.deltaTime;
        }
    }
}
