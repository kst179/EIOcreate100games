using UnityEngine;
using System.Collections;

public class CameraHinge : MonoBehaviour {

	void Update () {
		GameObject camera = GameObject.Find("Main Camera");

		camera.transform.position = transform.position;
		camera.transform.rotation = transform.rotation;
	}
}
