using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class WinCondition : MonoBehaviourPun
{

    [SerializeField] GameObject lose_menu;
    [SerializeField] GameObject win_menu;
    [SerializeField] private PhotonView view;



    private bool isPlayerAlive;
    private bool isEnemyAlive;



    private void OnTriggerEnter(Collider other)
    {
        if (view.IsMine)

            if (other.gameObject.tag == "Player")
            {

                lose_menu.SetActive(true);
                //object[] datas = new object[] { isPlayerAlive };
                //PhotonNetwork.RaiseEvent(PLAYER_DEATH_EVENT, datas, RaiseEventOptions.Default, SendOptions.SendUnreliable);
                //base.photonView.RPC("Win", RpcTarget.Others);

            }



    }

    [PunRPC]
    private void Win()
    {
        win_menu.SetActive(true);
    }


    //private const byte PLAYER_DEATH_EVENT=0;


    // Start is called before the first frame update


    //private void OnEnable()
    //{
    //    PhotonNetwork.NetworkingClient.EventReceived += NetworkingClient_EventReceived;
    //}

    //private void OnDisable()
    //{
    //    PhotonNetwork.NetworkingClient.EventReceived -= NetworkingClient_EventReceived;
    //}


    //private void NetworkingClient_EventReceived(EventData obj)
    //{
    //    if (obj.Code == PLAYER_DEATH_EVENT)
    //    {
    //        object[] datas = (object[])obj.CustomData;
    //        isEnemyAlive = (bool)datas[0];
    //        if (isEnemyAlive == false)
    //        {
    //            win_menu.SetActive(true);
    //        }
    //    }
    //}













}
