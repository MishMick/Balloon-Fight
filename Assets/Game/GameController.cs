using UnityEngine;
using System.Collections;

public class GameController : Controller<MainApplcation> {

	void Start() {
		app.addController (this);
	}

}