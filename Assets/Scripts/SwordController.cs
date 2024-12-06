using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    private bool isON=false;
    [SerializeField] private GameObject laser;


    public void TurnOnOFFLaser()
    {
        isON = !isON;
        laser.SetActive(isON);
            }
}
