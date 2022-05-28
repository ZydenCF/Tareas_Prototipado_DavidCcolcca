using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;

    [SerializeField] private float daño;

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OntriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            other.GetComponent<Enemigo>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }
    private void Flip(float _xFlip)
    {
        Vector3 flipPlayer = transform.localScale;
        if (_xFlip < 0)
        {
            flipPlayer.x = Mathf.Abs(flipPlayer.x) * -1;
        }
        else if (_xFlip > 0)
        {
            flipPlayer.x = Mathf.Abs(flipPlayer.x);
        }
        transform.localScale = flipPlayer;

    }
}
