using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeHouse : MonoBehaviour
{
    public GameObject NormalHouse;
    public GameObject ExplodeHousePrefab;
    
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            NormalHouse.SetActive(false);
            ExplodeHousePrefab.SetActive(true);
        }
    } 
}