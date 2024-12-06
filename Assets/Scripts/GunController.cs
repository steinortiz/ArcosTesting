using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform pivot;
    public void OnTriggerActivate()
    {
        GameObject ball = Instantiate(bulletPrefab, pivot.position, pivot.rotation);
        ball.transform.GetComponent<Rigidbody>().AddForce(pivot.forward * force);
    }
}