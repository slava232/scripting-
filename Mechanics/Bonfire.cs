using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime;
    public float tempUp = 0.2f;
    // Update is called once per frame
    void Update()
    {
        lifeTime -= 1 * Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Temperature>() != null)
        {
            other.GetComponent<Temperature>().TemperatureUp(tempUp);
        }
    }
}
