using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int health = 100;
	public static string PLAYER_TAG = "Player";
	public static string DIE_PANEL_TAG = "DiePanel";
	public GameObject diePanel;
	
	
	public bool Attack(int dmg) { // returns isAlive
		this.health -= dmg;
		if (this.health <= 0) {
			return this.Die();
		}
		return true;
	}
	
	public bool Die() {
		this.diePanel.SetActive(true);
		return false;
	}
	
	public void CollectPearls()
    {
        Storage.Pearls++;
    }

}
