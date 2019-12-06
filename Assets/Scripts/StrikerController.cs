using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StrikerController : MonoBehaviour {
  Rigidbody rb;
  float inputHorizontal;
  void Start() {
    rb = this.GetComponent<Rigidbody>();
  }

  void Update() {
    inputHorizontal = Input.GetAxisRaw("Horizontal");
    this.transform.position += Camera.main.transform.right * inputHorizontal * Time.deltaTime;
  }
}
