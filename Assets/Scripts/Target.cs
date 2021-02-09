using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 2f;
    public void DamageReceived(float damageDealt) {
        health -= damageDealt;
        if (health >= 0)
        {
            Die();
        }
    }
    void Die() {
        Destroy(gameObject);
    }
}
