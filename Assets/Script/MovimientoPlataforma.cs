using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private Transform suelo;

    [SerializeField] private float distancia;

    [SerializeField] private bool movimiendoDerecha;

    private Rigidbody2D playD;

    private void Start(){
        playD = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        RaycastHit2D informacionSuelo = Physics2D.Raycast(suelo.position, Vector2.down, distancia);

        playD.velocity = new Vector2(velocidad, playD.velocity.y);

        if (informacionSuelo == false)
        {
            //Girar
            Girar();
        }  
    }

    private void Girar()
    {
        movimiendoDerecha = !movimiendoDerecha;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
        velocidad *= -1;
    }

    private void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawLine(suelo.transform.position, suelo.transform.position + Vector3.down * distancia);
    }
}
