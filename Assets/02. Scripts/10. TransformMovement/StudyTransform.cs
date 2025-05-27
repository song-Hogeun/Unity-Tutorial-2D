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
public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    private void Update()
    {
        // 월드 방향으로 이동
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        // transform.localPosition += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        // 월드 방향으로 이동
        // transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        
        // 월드 방향으로 회전
        // transform.rotation = Quaternion.Euler(localX, angle, localZ);
        
        // 로컬 방향으로 회전
        // transform.localRotation = Quaternion.Euler(localX, angle, localZ);
        
        // 로컬 방향으로 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략
        
        // 월드 뱡향으로 회전
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
        
        // 특정 위치의 주변을 회전
        // transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), rotateSpeed * Time.deltaTime);
        
        // 특정 위치를 바라보며 회전
        transform.LookAt(Vector3.zero);
    }
}