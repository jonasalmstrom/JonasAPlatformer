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
        ehm = FindObjectOfType<EnemyHorizontalMovement>();
        if (ehm.goLeft == true)
        {
            rb.AddForce(-Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        Destroy(gameObject, 3);
    }
}
