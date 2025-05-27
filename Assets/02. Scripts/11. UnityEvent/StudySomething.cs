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
public class StudySomething : MonoBehaviour
{
	public int currentLevel = 10;
	public int maxLevel = 99;

	private void Start()
	{
		string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다.";
		
		int levelPoint = currentLevel >= maxLevel ? 0 : 1;
		
		currentLevel += levelPoint;
		
		Debug.Log(msg);
	}
}
