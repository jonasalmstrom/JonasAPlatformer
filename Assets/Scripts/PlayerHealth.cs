using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// gör så att vi kan använda Unity UI
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;

    public Slider healthbar;

    public float currentHealth;




    private void Start()
    {
        //sätter currentHealth till health vilket är maxhealth 
        currentHealth = health;
        //sätter valuet på healthbaren till calculatehealth
        healthbar.value = CalculateHealth();
    }

    //gör en funktion där man kan sätta in en float inom parantesen beroende på situationen
    void DealDamage(float damageValue)
    {
        currentHealth -= damageValue;
        //sätter healthbaren till calculatehealth igen
        healthbar.value = CalculateHealth();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //om objektet kolliderar med något som har taggen SmallEnemy så kör den funktionen DealDamage med 50 som värde
        if (collision.gameObject.tag == "SmallEnemy")
        {
            DealDamage(50f);
        }

        if (collision.gameObject.tag == "Projectile")
        {
            DealDamage(50f);
            Destroy(collision.gameObject);
        }
    }

    //gör en float vid namn calculatehealth som returnerar värdet av currentHealth / health
    float CalculateHealth()
    {
        return currentHealth / health;
    }

    void Update()
    {
        //om currenthealth är mindre än eller 0 så restartar den scenen
        if (currentHealth <= 0f)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}
