using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private PhotonView view;
    private Rigidbody rb;
    private float _inputHorizontal; 
    private float _inputVertical;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (view.IsMine)
        {
            _inputHorizontal = Input.GetAxisRaw("Horizontal");
            _inputVertical = Input.GetAxisRaw("Vertical");


            Vector3 forceMovement = new Vector3(_inputHorizontal * speed, 0, _inputVertical * speed);
            rb.AddForce(forceMovement);

        }
    }



}
