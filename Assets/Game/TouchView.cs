using UnityEngine;
using System.Collections;

public class TouchView : View<MainApplcation> 
{
	//inside class
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;

	void Update () 
	{
		
		#if UNITY_EDITOR
		//keyboard controls
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			Notify (PlayerNotifications.left, this);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{	    
			Notify (PlayerNotifications.right, this);
		}
		if (Input.GetKey (KeyCode.Space)) 
		{
			Notify ( PlayerNotifications.jump, this);
		} 
		#endif

		#if UNITY_IPHONE
		Debug.Log("iOS Code goes here!");
		#endif

		#if UNITY_ANDROID
		//touch controls
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
		{
			Vector2 touchPosition = Input.GetTouch(0).position;
			double halfScreen = Screen.width / 2.0;
			//Check if it is left or right?
			if(touchPosition.x < halfScreen)
			{
				Notify (PlayerNotifications.left, this);
			}
			else if (touchPosition.x > halfScreen) 
			{
				Notify (PlayerNotifications.right, this);
			}
		}
		//flying
		if(Input.touches.Length > 0)
		{
			Touch t = Input.GetTouch(0);
			if(t.phase == TouchPhase.Began)
			{
				//save began touch 2d point
				firstPressPos = new Vector2(t.position.x,t.position.y);
			}
			if(t.phase == TouchPhase.Ended)
			{
				//save ended touch 2d point
				secondPressPos = new Vector2(t.position.x,t.position.y);

				//create vector from the two points
				currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

				//normalize the 2d vector
				currentSwipe.Normalize();

				//swipe upwards
				if(currentSwipe.y > 0)
				{
					Debug.Log("up swipe");
					Notify(PlayerNotifications.jump,this);
				}
			}
		}
		#endif
	}

}
