using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 3.0f; //Variable de la velocidad

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Speed;
        
    }

    private void OncollisionEnter2D(Collision2D collision)
    {
        
         Destroy(gameObject);
    }
}
