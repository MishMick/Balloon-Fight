using UnityEngine;
using System.Collections;

/// <summary>
/// Main Class that handles the BalloonFight Game
/// </summary>
public class MainApplcation : BaseApplication<GameModel,GameView,GameController> {

	new void Start() {
		base.Start ();

		Debug.Log ("Application is Upto date and running");
	}

}
