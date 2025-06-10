// System
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
// Unity
	using UnityEngine;
	using UnityEngine.UI;
	using Random = System.Random;

	// Project
// Alias

/// <summary>
/// 클래스 설명을 적는 곳 입니다.
/// <summary>
public class StudyRandom : MonoBehaviour
{
	void OnEnable()
	{
		int ranNumber = UnityEngine.Random.Range(0, 100);
		Debug.Log(ranNumber);
	}
}
