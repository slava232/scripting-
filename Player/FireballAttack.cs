using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    public GameObject fireballPrefab;

    //Место откуда огненый шар появляеться
    public Transform attackPoint;
    // Start is called before the first frame update
    private void Update()
    {
        //Условие нажатие на лкм
        if (Input.GetMouseButtonDown(0))
        {
            //Создание копии(префаб,где появиться,поворот)
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
