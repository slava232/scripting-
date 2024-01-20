using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovment : MonoBehaviour
{
    //Скорость ходьбы
    public float speed = 6.0f;
    //Скорость бега
    public float runSpeed = 12.0f;
    //Целевая скороость для смены состояний между ходьбой и бегом
    float targetMovementSpeed;
    //Возможность использовать механику бега
    public bool canRun = true;
    //Проверка на нажатие клавиши
    public bool isRunning;
    //Клавиша бега
    public KeyCode runButton = KeyCode.LeftShift;
    //Компонент rigidbody для физики
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Проверка на возможность бега
        if(canRun == true)
        {
            //Проверка на нажатие клавиши
            if (Input.GetKey(runButton))
            {
                isRunning = true;
            }
            else
            {
                isRunning = false;
            }
            //В зависимости от правдивости переменной isRunning задаёт 1 из 2 значений
            targetMovementSpeed = isRunning ? runSpeed : speed;
            //Изменяем физичискую скорость умножая её на новый вектор(Горизонтальная ось,Текущее значение velocity.y,Вертикальная ось умноженная на текущую скорость)
            rb.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), rb.velocity.y, Input.GetAxis("Vertical") * targetMovementSpeed);
            //Поворот персонажа по оси у умноженой на горизонтальную ось умноженую на 100 умноженую на 1 секунду реального времени в локальной системе координат
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
        }
    }
}
