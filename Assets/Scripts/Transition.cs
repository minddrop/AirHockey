using UnityEngine;
using UnityEngine.SceneManagement;

namespace AirHockey {
  public class Transition : MonoBehaviour {
    void Start() {
      this.tag = Common.Tags.SceneManager;
      Debug.Log("set scenemanager tag");
    }
    public void LoadScene(string sceneName) {
      Debug.Log("transition loadscene");
      SceneManager.LoadScene(sceneName);
    }
  }
}
