using UnityEngine;
using System.Collections;

public class GameController : Controller<MainApplcation> 
{

	void Start() 
	{
		app.addController (this);
	}

	public override void OnNotification(string p_event, Object p_target, params object[] p_data)
	{
		if (p_event == "player.left") {
			app.view.player.moveLeft ();
		}
		if (p_event == "player.right") {
			app.view.player.moveRight ();
		}
		if (p_event == "player.jump") {
			app.view.player.jump ();
		}

	}

}