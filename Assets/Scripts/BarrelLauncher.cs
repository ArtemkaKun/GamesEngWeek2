using System;
using System.Collections;
using UnityEngine;

public class BarrelLauncher : MonoBehaviour
{
    [SerializeField] private GameObject barrelPrefab;

    private void Start() => StartCoroutine(LaunchOneBarrel());

    private IEnumerator LaunchOneBarrel()
    {
        for(;;)
        {
            var barrel = Instantiate(barrelPrefab);
            barrel.transform.position = transform.position;
            yield return new WaitForSeconds(9f);
        }
    }
}
