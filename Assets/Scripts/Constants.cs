using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AirHockey.Common {
  public static class Constants {
    public enum Scoerer {
      You,
      Opponent
    }

    public enum Result {
      Win,
      Lose
    }
  }

  public static class Tags {
    public const string SceneManager = "SceneManager";
    public const string GameManager = "GameManager";
  }

}
