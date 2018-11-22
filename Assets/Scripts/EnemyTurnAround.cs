using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnAround : MonoBehaviour
{

    public bool isLeft = true;
    //en funktion som konstant känner av om någonting colliderar med objektet den sitter på
    private void OnTriggerEnter2D(Collider2D collider)
    {
        //om objektet kolliderar med en tag som heter "EnemyBorder" så körs detta
        if (collider.tag == "EnemyBorder")
        {
            //om isLeft är true
            if (isLeft == true)
            {
                //transformerar scalen på gameobjectet med -1 i x och stannar samma i y
                transform.localScale = new Vector2(-1, transform.localScale.y);
                //sätter isLeft till false för att den nu kollar åt höger
                isLeft = false;
                //här hittar den ett gameobject med taggen "Enemy" och döper den till "EnemyRat" i detta script
                GameObject EnemyRat = GameObject.FindWithTag("Enemy");
                //om enemyrat inte är null så
                if (EnemyRat != null)
                {
                    //acessar den scriptet "EnemyHorizontalMovement" och döper det till "horiz"
                    EnemyHorizontalMovement horiz = EnemyRat.GetComponent<EnemyHorizontalMovement>();
                    //här sätter den variabeln "goLeft" i scriptet "horiz" till false
                    horiz.goLeft = false;
                }
            }
            //om isLeft är false så händer detta
            else
            {
                //sätter ifLeft till true
                isLeft = true;
                //ändrar scalen till +1 igen så att den facear höger (flippar)
                transform.localScale = new Vector2(1, transform.localScale.y);
                //här hittar den ett gameobject med taggen "Enemy" och döper den till "EnemyRat" i detta script
                GameObject EnemyRat = GameObject.FindWithTag("Enemy");
                //om enemyrat inte är null så
                if (EnemyRat != null)
                {
                    //här sätter den variabeln "goLeft" i scriptet "horiz" till true
                    EnemyHorizontalMovement horiz = EnemyRat.GetComponent<EnemyHorizontalMovement>();
                    horiz.goLeft = true;
                }
            }
        }
    }
}
