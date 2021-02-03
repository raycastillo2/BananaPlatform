using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;



    private void Awake() {
        instance = this;
    }
    public void Respawn() {
        GameObject Player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);

    }
    
}
