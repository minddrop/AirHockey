using UnityEngine;
using AirHockey;

namespace AirHockey {
  public class RivalController : MonoBehaviour {
    public Transform puckTransform;
    int[] intArray = new int[100];

    void Start() {
      GameObject puck = GameObject.Find("Puck");
      puckTransform = puck.GetComponent<Transform>();

    }

    void Update() {
      this.transform.position = new Vector3(puckTransform.position.x, this.transform.position.y, this.transform.position.z);

    }
  }

  // public static void a(GameManager.Result a) {
  //   Debug.Log(a);
  // }
}
