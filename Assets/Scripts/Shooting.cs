using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firepoint;
    float nextFire = 0;
    public float fireRate;
    public GameObject projectile;

    private void FixedUpdate()
    {
        //sätter nextfire +1 varje sekund
        nextFire += Time.deltaTime;

        //om nextfire är större eller lika med firerate så instantiatear (spawnar) man en projektil vid firepointen. Sedan sätter man nextfire till 0 så att det kan restarta
        if (nextFire >= fireRate)
        {
            Instantiate(projectile, firepoint.position, Quaternion.identity);
            nextFire = 0;
        }
    }
}
