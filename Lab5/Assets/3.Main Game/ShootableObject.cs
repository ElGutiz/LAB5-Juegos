using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableObject : MonoBehaviour
{
    public int currentHealth = 3;
    public static int points = 0;
    public bool choose;

    public AudioClip pointsAudio1;
    public GameObject GameFinishedMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            points = points + 1;
            choose = false;
            gameObject.SetActive(false);
        }

        if (currentHealth > 0)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.PlayOneShot(pointsAudio1);
        }
    }
}
