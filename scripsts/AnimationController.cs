using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	public Animator animator;
	public bool run = false;
	public bool die = false;
	public bool victory = false;
	public bool defence = false;
	public bool attack = false;
		
	void Update () {
		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0)
			run = true;
		else
			run = false;
		if (Input.GetAxis ("Attack") != 0) {
			attack = true;
			run = false;
		} else
			attack = false;
		if (Input.GetAxis ("Defence") != 0){
			defence = true;
			run = false;
		}
		else defence = false;

		animator.SetBool("running", run);
		animator.SetBool("attack", attack);
		animator.SetBool("defence", defence);
		animator.SetBool("die", die);
		animator.SetBool("victory", victory);
	}
}
