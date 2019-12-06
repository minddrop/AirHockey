using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PuckController : MonoBehaviour {
  Rigidbody rb;

  void Start() {
    rb = this.GetComponent<Rigidbody>();
    rb.velocity = new Vector3(2, 0, 2);
  }

  // Update is called once per frame
  void Update() {
    rb.velocity += rb.velocity / 1000;
  }
}
