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
public class PlanetRotation : MonoBehaviour
{
	public Transform targetPlanet;
	
	public float rotSpeed = 30f;
	
	public float revolutionSpeed = 100f;
	
	public bool isRevolution = false;

	void Update()
	{
		// 자기 자신이 회전하는 기능
		transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

		if (isRevolution)
		{
			transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
		}
	}
}
