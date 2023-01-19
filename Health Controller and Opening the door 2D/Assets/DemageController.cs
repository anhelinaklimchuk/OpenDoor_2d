using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageController : MonoBehaviour
{
	[SerializeField] private int bombDamage;
	[SerializeField] private HealthControl _healthController;

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			Damage();
		}
	}
	void Damage(){
		_healthController.playerHealth=_healthController.playerHealth-bombDamage;
		_healthController.UpdateHealth();
		gameObject.SetActive(false);
	}
}
