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
public class Skill : MonoBehaviour
{
	public GameObject skill1;
	public GameObject boom;
	public Transform skill1Pos;
	
	private GameObject obj;
	private GameObject boomObj;

	public float rotSpeed;
	
	public void UseSkill()
	{
		obj = Instantiate(skill1, skill1Pos.position, Quaternion.identity);
		Invoke("DestroySkill", 0.7f);
	}

	void DestroySkill()
	{
	}
}
