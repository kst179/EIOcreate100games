using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float low_border;
	public float high_border;
	public GameObject character;
	public GameObject camera_axe;
	public float sensivityX = 1;
	public float sensivityY = 1;

	void Start(){
		Screen.showCursor = false;
	}

	void Update () {
		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");

		x *= sensivityX;
		y *= sensivityY;

		gameObject.transform.Rotate (0, x*Time.deltaTime, 0);
		character.transform.Rotate (0, -x*Time.deltaTime, 0);

		camera_axe.transform.Rotate (y*Time.deltaTime, 0, 0);
		if (camera_axe.transform.eulerAngles.x < low_border ||
		    camera_axe.transform.eulerAngles.x > high_border) {
			camera_axe.transform.Rotate (-y*Time.deltaTime, 0, 0);
		}
	}
}
