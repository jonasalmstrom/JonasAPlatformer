using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 100;
    EnemyHorizontalMovement ehm;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ehm = GameObject.Find("EnemyBee").GetComponent<EnemyHorizontalMovement>();

        //om variabeln "goLeft" i scriptet EnemyHorizontalMovement är true
        if (ehm.goLeft == true)
        {
            //lägger en force på rigidbodyn samt gör så att den är beroende av time.deltatime. Forcemode2D.impulse innebär att man får en force direkt när man callar den och inte någon gång mer
            rb.AddForce(-Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        Destroy(gameObject, 2);
    }
}
