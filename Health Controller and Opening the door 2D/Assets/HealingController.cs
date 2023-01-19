using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingController : MonoBehaviour
{
	[SerializeField] private int addHealth;
	[SerializeField] private HealthControl _healthController;

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			Healing();
		}
	}
	void Healing(){
		_healthController.playerHealth=_healthController.playerHealth+addHealth;
		_healthController.UpdateHealth();
		gameObject.SetActive(false);
	}
}
