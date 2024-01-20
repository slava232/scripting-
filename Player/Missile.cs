using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //Переменная которая хранит скорость
    public float speed = 10;


    private void Start()
    {
        //Уничтожение объекта через 3 секунды 
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    { 
        //Движение объекта вперёд
        transform.position +=transform.forward * speed * Time.deltaTime;
    }
    //Обработка столкновения
    private void OnTriggerEnter(Collider other)
    {
        //Уничтожение обоих объекта
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
