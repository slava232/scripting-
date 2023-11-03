using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leave : MonoBehaviour
{
    int level = 5;
    int health = 2;
    int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = this.transform.position;
        newpos.z += speed * Time.deltaTime;
        transform.position = newpos;
    }
}
