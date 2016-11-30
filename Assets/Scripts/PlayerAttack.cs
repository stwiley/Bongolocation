using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

    public int attackDamage = 10;               // The amount of health taken away per attack.

    GameObject enemy;                          // Reference to the player GameObject.
    EnemyHealth enemyHealth;                    // Reference to this enemy's health.
    bool enemyInRange;                         // Whether player is within the trigger collider and can be attacked.
    float timer;                                // Timer for counting up to the next attack.


    void Awake()
    {
        // Setting up the references.
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        enemyHealth = enemy.GetComponent<EnemyHealth>();
    }


    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == enemy)
        {
            // ... the player is in range.
            enemyInRange = true;
            print(enemyInRange);
        }
    }


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        if (other.gameObject == enemy)
        {
            // ... the player is no longer in range.
            enemyInRange = false;
        }
    }


    void Update()
    {

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if ((Input.GetButtonDown("RotateLeft") && Input.GetButton("RotateRight") || Input.GetButtonDown("RotateRight") && Input.GetButton("RotateLeft")) && enemyInRange ==true)
        {
            Input.ResetInputAxes();
            //  ... attack.
            Attack();
        }

    }


    void Attack()
    {

        // If the player has health to lose...
        if (enemyHealth.currentHealth > 0)
        {
            // ... damage the player.
            enemyHealth.TakeDamage(attackDamage);
            print(enemyHealth.currentHealth);
            Input.ResetInputAxes();

        }
    }
}
