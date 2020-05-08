using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using AirHockey.Common;

namespace AirHockey {
  class GameEvent : UnityEvent<string> { };

  public class GameManager : MonoBehaviour {
    GameEvent loadScene;

    void Start() {
      if (this.tag != Common.Tags.GameManager) Debug.LogWarning("This object needs ");
      // int i = 0;
      // while (true) {
      //   i++;
      //   if (HasGameObjectWithTag(Common.Tags.SceneManager)) {
      //     Debug.Log("scenemanager exists");
      //     loadScene = new GameEvent();
      //     loadScene.AddListener(GameObject.FindWithTag(Common.Tags.SceneManager).GetComponent<Transition>().LoadScene);
      //     break;
      //   }
      //   Debug.Log("Doesn't exist scemanagers");
      //   if (i == 100) {
      //     loadScene = new GameEvent();
      //     break;
      //   }
      // }
      LoadScene("Title");

    }

    public void LoadScene(string sceneName) {
      Debug.Log("gamemanager loadscene");
      loadScene.Invoke(sceneName);
    }

    public void Goal(Common.Constants.Scoerer s) {
      Debug.Log(s + " scored.");
    }

    bool HasGameObjectWithTag(string tag) {
      return GameObject.FindWithTag(tag) != null;
    }

  }
}
