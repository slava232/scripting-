using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2;
    public Transform target;
    public int damage = 2;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards
            (transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)

    {
        other.GetComponent<Health>().TakeDamage(damage);
    }
}
