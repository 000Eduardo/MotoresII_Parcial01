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
/*
            if (_inputHorizontal !=0 || _inputVertical != 0)
            {
                
            }
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
            }

            
            if (Input.GetKey("d")) transform.position += Vector3.right * speed * Time.deltaTime;
            if (Input.GetKey("a")) transform.position += Vector3.left * speed * Time.deltaTime;
            if (Input.GetKey("w")) transform.position += Vector3.forward * speed * Time.deltaTime;
            if (Input.GetKey("s")) transform.position += Vector3.back * speed * Time.deltaTime;
            */
        }
    }



}
