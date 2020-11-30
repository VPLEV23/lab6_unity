using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorayEelEnemy : Enemy {
	private int enteredTriggers = 0;
	private bool follow = false;
	public float speed = 1f;
 
	void Update() {
		if (this.follow) {
			Vector3 playerPos = new Vector3(
				this.GetPlayer().transform.position.x, 
				this.GetPlayer().transform.position.y, 
				this.GetPlayer().transform.position.z
				);
			transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
		}
	}

    private void OnTriggerEnter(Collider other) {
		enteredTriggers++;
		if (enteredTriggers == 1) {
			this.FollowPlayer(true);
		} else if (enteredTriggers == 2) {
			this.AttackPlayer();
		}
    }

	private void FollowPlayer(bool follow) {
		this.follow = follow;
	}
	
    private void OnTriggerExit(Collider other) {
        enteredTriggers--;
    }
}
