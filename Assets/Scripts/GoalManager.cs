using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AirHockey {
  public class GoalManager : MonoBehaviour {
    private GameManager gameManager;

    void Start() {
      gameManager = GameObject.FindWithTag(Common.Tags.GameManager).GetComponent<GameManager>();
    }
    void OnCollisionEnter(Collision other) {
      gameManager.SendMessage("goal");
    }
  }
}
