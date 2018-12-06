using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    //detta scriptet använder jag inte
    public Camera mainCamera;

    private float shakeAmt = 0;

    //awake är samma som start fast körs så fort spelet startas, Start körs när scriptet startar
    private void Awake()
    {
        //den kollar om maincamera inte existerar och sätter maincamera till camera (failproof)
        if (mainCamera == null)
            mainCamera = Camera.main;
    }
    //funktion som bestämmer hur mycket det ska skaka och hur länge 
    public void Shake(float amt, float length)
    {
        shakeAmt = amt;
        InvokeRepeating("BeginShake", 0, 0.01f);
        Invoke("StopShake", length);
    }
    //startar skakningen
    void BeginShake()
    {

        if (shakeAmt > 0)
        {
            //gör en vector3 med samma position som maincamera
            Vector3 camPos = mainCamera.transform.position;
            //
            float offsetX = Random.value * shakeAmt * 2 - shakeAmt;
            float offsetZ = Random.value * shakeAmt * 2 - shakeAmt;
            camPos.x += offsetX;
            camPos.y += offsetZ;

            mainCamera.transform.position = camPos;
        }
    }
    void StopShake()
    {
        CancelInvoke("BeginShake");
        mainCamera.transform.localPosition = Vector3.zero;
    }
}
