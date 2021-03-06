using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAttackSet : MonoBehaviour
{
	public GameObject MainObject;
	public GameObject Player;
	public float Damage;
	public bool IsAttack = false;
	public BoxCollider HitBox;
    //Start is called before the first frame update
    void Start()
    {
		Player = GameObject.Find ("Player");
		HitBox = GetComponent<BoxCollider> ();
    }

    // Update is called once per frame
    void Update()
    {
		Damage = Player.GetComponent<Status> ().CurrentDamage;
		IsAttack = Player.GetComponent<Status> ().IsBasicAttack;
		if (MainObject.gameObject.gameObject == Player.GetComponent<SkillConfig> ().ClickAttack.gameObject) {
			HitBox.enabled = true;
		} else {
			HitBox.enabled = false;
		}
    }
}
