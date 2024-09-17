using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Roomanager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    [Space]
    public Transform Spawnpoint;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting...");

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        Debug.Log("Connected to Server");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.JoinOrCreateRoom("test" , null , null );

        Debug.Log("were connected and in a room now");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log("We,re connected to a room");

        GameObject _player = PhotonNetwork.Instantiate(player.name, Spawnpoint.position, Quaternion.identity);
        _player.GetComponent<Playersetup>().Islocalplayer();

    }


}
