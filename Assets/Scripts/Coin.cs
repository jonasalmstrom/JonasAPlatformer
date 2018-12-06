using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    public GameObject Effect;
    //en funktion som konstant känner av om någonting colliderar med objektet den sitter på
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om det är ett objekt med taggen "Player" colliderar med objektet så körs det som står nedan
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel "controller" och sätt den till resultatet av sökningen efter objektet med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            //om controller inte är lika med null
            if (controller != null)
            {
                //skapa en temporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                //gör sönder coinen
                Destroy(gameObject);
                Instantiate(Effect, transform.position, Quaternion.identity);
                //om tracker inte är lika med null
                if (tracker != null)
                {
                    //totalscore adderas med score vilket resulterar i det rätta poäng värdet
                    tracker.totalScore += score;
                }
                else
                {
                    //om någonting går fel så printar den ut detta medelandet i konsolen
                    Debug.LogError("ScoreTracker saknas på GameController");
                }


            }
            else
            {
                //om gamecontroller inte finns så printar den ut fdet i konsolen
                Debug.LogError("GameController finns inte");
            }
        }
    }
}
