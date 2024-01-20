using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip damageSound;

    //Здоровье
    public int health = 10;

    public int maxhealth = 10;

    //Метод получения урона
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            print("Health:" + health);
            audioSource.PlayOneShot(damageSound);

        }
        else
        {
            print("You Dead");
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
