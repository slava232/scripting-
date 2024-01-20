using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriger : MonoBehaviour
{
    //Класс увелечения скорости
    //Поле множителя скорости
    public float speed_factor = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speed_factor;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speed_factor;
    }
}
