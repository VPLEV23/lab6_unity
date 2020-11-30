using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private Player player;
	private int damage = 100;
	
	// Start is called before the first frame update
    void Start() {
		this.SetPlayer(GameObject.FindWithTag(Player.PLAYER_TAG).GetComponent<Player>());
    }
	
	
	public void SetPlayer(Player player) {
		this.player = player;
	}
	public Player GetPlayer() {
		return this.player;
	}
	
	public void SetDamage(int damage) {
		this.damage = damage;
	}
	public int GetDamage() {
		return this.damage;
	}
	
	public void AttackPlayer() {
		this.player.Attack(this.damage);
	}
}
