using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject PlayerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(0, 3), 0,Random.Range(0, 3));
        PhotonNetwork.Instantiate(PlayerPrefab.name, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
