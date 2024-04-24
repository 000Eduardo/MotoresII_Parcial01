using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;

    private void Start()
    {
        Vector3 randomposition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(player.name, randomposition, Quaternion.identity);
    }


}
