using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {

	public GameObject capsule;
	public float velocity;
	public double eps = 0.1;
	public float rotate_velocity;

	void Update () {

		AnimationController ac = gameObject.GetComponent <AnimationController>();

		if (ac.victory || ac.die)
			return;

		Vector3 moveto = new Vector3 (Input.GetAxis ("Horizontal"),
		                              0,
		                              Input.GetAxis ("Vertical"));

		Vector3 lookto = moveto.normalized;
		if (!ac.attack && !ac.defence && ac.run) {
			capsule.transform.Translate(moveto*velocity*Time.deltaTime);
		}

		float cosa = Vector3.Dot (new Vector3(0,0,1), lookto);
		float sina = Vector3.Cross (new Vector3(0,0,1), lookto).y;

		Vector3 loc = capsule.transform.forward.normalized;

		float z = loc.z * cosa - loc.x * sina;
		float x = loc.z * sina + loc.x * cosa;

		lookto = new Vector3(x, 0, z);

		if (lookto.magnitude > eps) {
			if (Vector3.Cross (transform.forward, lookto).y < -eps) {
				gameObject.transform.Rotate (0, -Time.deltaTime * rotate_velocity, 0);
			}
			else
			if (Vector3.Cross (transform.forward, lookto).y > eps) {
				gameObject.transform.Rotate (0, Time.deltaTime * rotate_velocity, 0);
			}
			else
			if(Vector3.Dot (transform.forward, lookto) < 0){
				gameObject.transform.Rotate (0, Time.deltaTime * rotate_velocity, 0);
			}
		}
	}
}
