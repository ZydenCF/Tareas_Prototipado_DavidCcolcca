using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTopdown1 : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;

    [SerializeField] private Vector2 direccion;

    private Rigidbody2D playerRb;


    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direccion = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}

