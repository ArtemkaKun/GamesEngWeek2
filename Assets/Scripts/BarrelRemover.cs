using System;
using UnityEngine;

public class BarrelRemover : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name != "player") Destroy(other.gameObject);
    }
}
