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
public class DestroyEvent : MonoBehaviour
{
	public float destroyTime = 3f;
    
	void Start()
	{
		Destroy(this.gameObject, destroyTime); // 자기 자신을 3초 뒤에 파괴하는 기능
		
		Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
	}

}
