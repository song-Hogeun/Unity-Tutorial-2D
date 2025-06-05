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
public class NumberKeyPad : MonoBehaviour
{
	public Animator doorAnim;
	
	public GameObject doorLock;
	
	public string password;			// 비밀번호 설정
	public string keyPadNumber;		// 입력한 숫자 적용

	public void OnInputNumber(string numString)
	{
		keyPadNumber += numString;
	}

	public void OnCheckNumber()
	{
		if(keyPadNumber == password)
		{
			doorLock.gameObject.SetActive(false);
			keyPadNumber = "";
			Debug.Log("비밀번호가 일치합니다. 문이 열렸습니다.");
			
			doorAnim.SetTrigger("Door Open");
		}
		else
		{
			keyPadNumber = "";
			Debug.Log("비밀번호가 틀렸습니다. 다시 입력해주세요.");
		}
	}
}
