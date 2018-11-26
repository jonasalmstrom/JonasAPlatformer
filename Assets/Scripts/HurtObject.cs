using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //en funktion som konstant känner av om någonting colliderar med objektet den sitter på
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //om det är ett objekt med taggen "Player" colliderar med objektet så körs det som står nedan
        if (collision.gameObject.tag == "Player")
        {
            //den känner av vilken scen som är nuvarande aktiv och sedan tar namnet på den aktiva scenen och loadar den från början, samt skapar en temporär variabel kallad "active"
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);

        }
    }
}
