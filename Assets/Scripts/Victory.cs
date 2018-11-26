using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{

    public string levelToLoad;

    private void Update()
    {
        //om man trycker space så loadar man scenen "Level1"
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Level1");
        }
    }
    //en funktion som konstant känner av om någonting colliderar med objektet den sitter påk
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om det är ett objekt med taggen "Player" colliderar med objektet så körs det som står nedan
        if (collision.tag == "Player")
        {
            //den printar ett medelande för att man ska kunna se att det funkar samt att den loadar scenen som stringen "levelToLoad" är satt till i inspectorn
            print("WOOOOOOOWEEEE");
            SceneManager.LoadScene(levelToLoad);

        }
    }

}
