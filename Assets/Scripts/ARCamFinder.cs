using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ARCamFinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        var x = GameObject.FindGameObjectWithTag("MainCamera");
        if (GetComponent<PhotonView>().IsMine)
        {
            x.transform.SetParent(transform);
            x.transform.position = Vector3.zero;
        }
    }

}
