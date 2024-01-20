using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed = 2.5f;
    public Vector3 direction;
    public bool activity = false;
    

    // Update is called once per frame
    void Update()
    {
        if (activity)
        {
            transform.position += direction * speed * Time.deltaTime;
            print(direction + ":" + speed);
            print(activity);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activity = true;
        }
        if (other.CompareTag("PlatformStop"))
        {
            speed *= -1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activity = false;
        }
    }
}
