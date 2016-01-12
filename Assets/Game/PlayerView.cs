using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerView : View<MainApplcation> 
{
	public GameObject balloon;
	private GameObject ball;
	Vector3 offset = new Vector3 (0, 1.25f, 1);
	void Start()
	{
		transform.position = new Vector3 (0, 0,0);
		ball = Instantiate(balloon,transform.position+offset,Quaternion.identity) as GameObject;
	}
	void Update()
	{
		ball.transform.position = transform.position + offset;
	}
	public void moveLeft()
	{
		transform.Translate(Vector3.left * 5 * Time.deltaTime);
		ball.transform.position =transform.position+offset;
	}
	public void moveRight()
	{
		transform.Translate(Vector3.right * 5 * Time.deltaTime);
		ball.transform.position =transform.position+offset;

	}
	public void jump()
	{
		Vector2 force = new Vector2 (0, 20f);
		GetComponent<Rigidbody2D> ().AddForce (force, ForceMode2D.Force);
		ball.transform.position =transform.position+offset;

	}

}