using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableObject : MonoBehaviour
{
    public int currentHealth = 3;
    public static int points = 0;

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            points = points + 1;
            gameObject.SetActive(false);
        }
    }
}
