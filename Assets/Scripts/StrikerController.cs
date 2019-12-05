﻿using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StrikerController : MonoBehaviour {
  Rigidbody rb;
  float inputHorizontal;
  float inputVertical;
  void Start() {
    rb = this.GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update() {
    inputHorizontal = Input.GetAxisRaw("Horizontal");
    inputVertical = Input.GetAxisRaw("Vertical");
    rb.velocity = Camera.main.transform.right * inputHorizontal;
  }
}
