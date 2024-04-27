using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviourPun
{

    [SerializeField]
    private GameObject player;

    private Renderer playerRenderer;

    private Color newPlayerColor;

    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    
    // Start is called before the first frame update
    void Awake()
    {
        playerRenderer = player.GetComponent<Renderer>();

        randomChannelOne = Random.Range(0f,1f);
        randomChannelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newPlayerColor = new Color (randomChannelOne, randomChannelTwo, randomChannelThree, 1f);

        playerRenderer.material.SetColor("_Color", newPlayerColor);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
