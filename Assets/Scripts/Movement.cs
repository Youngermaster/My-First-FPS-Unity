using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour {

    public CharacterController controller;
    public float speed = 20f;

    private void Start() {
        
    }

    private void Update() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;
        controller.Move(movement * speed * Time.deltaTime);
    }
}