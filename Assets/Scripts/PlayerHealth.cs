using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;

    public Slider healthbar;

    public float currentHealth;
    



    private void Start()
    {
        currentHealth = health;

        healthbar.value = CalculateHealth();
    }

    void DealDamage(float damageValue)
    {
        currentHealth -= damageValue;
        healthbar.value = CalculateHealth();
        
    } 


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SmallEnemy")
        {
            DealDamage(50f);
        }
    }

    float CalculateHealth()
    {
        return currentHealth / health;
    }

    void Update()
    {

        if (currentHealth <= 0f)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}
