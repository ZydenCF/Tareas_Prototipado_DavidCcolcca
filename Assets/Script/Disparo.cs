using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
   public Projectile LaBala; //Se indica cual es el proyectil o bala
   public Transform PuntoDisparo; //Desde donde va a salir la bala

   void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
            Instantiate(LaBala, PuntoDisparo.position, transform.rotation);
        }
    }

}
