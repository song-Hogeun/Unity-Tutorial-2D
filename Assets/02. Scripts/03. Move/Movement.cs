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
/// 어몽어스 캐릭터의 이동 관련 코드를 작성하는 스크립트 입니다.
/// <summary>
 public class Movement : MonoBehaviour
 {
     public float moveSpeed = 5f;
     public static int coin;
     
     void Update()
     {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");  
         
        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized; // 정규화 과정 (0 ~ 1)
         
        transform.position += normalDir * moveSpeed * Time.deltaTime;

		transform.LookAt(transform.position + normalDir);
     }
 }
