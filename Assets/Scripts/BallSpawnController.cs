using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject spawnPlace;

    // Update is called once per frame
    public void OnButtonPress()
    {
        Instantiate(ballPrefab,spawnPlace.transform.position, Quaternion.identity);
    }
}
