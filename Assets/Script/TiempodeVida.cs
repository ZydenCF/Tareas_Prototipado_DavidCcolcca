using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempodeVida : MonoBehaviour
{
    [SerializeField] private float tiempodeVida;

    private void Star()
    {
        Destroy(gameObject, tiempodeVida);
    }
}
