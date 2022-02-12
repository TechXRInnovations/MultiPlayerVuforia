using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("Test");
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom("Test");
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("03-Game");
    }
}
