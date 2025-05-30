// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;

// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class Coin : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			++Movement.coin;
			Debug.Log($"현재까지 {Movement.coin} 코인 획득!!");
			Destroy(this.gameObject);
		}
	}
	
}
