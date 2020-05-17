using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject winText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "player")
        {
            winText.SetActive(true);
        }
    }
}
