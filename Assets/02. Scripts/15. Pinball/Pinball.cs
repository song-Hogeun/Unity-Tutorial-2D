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
public class Pinball : MonoBehaviour
{
	public PinballManager pinballManager;
	
	public GameObject particle;
	public bool gameOver;
    void OnCollisionEnter2D(Collision2D coll)
    {
	    if (coll.gameObject.CompareTag("Score10"))
	    {
		    Debug.Log("Score 10");
		    pinballManager.score += 10;
		    Instantiate(particle, transform.position, Quaternion.identity);
	    }

	    else if (coll.gameObject.CompareTag("Score30"))
	    {
		    Debug.Log("Score 30");
		    pinballManager.score += 30;
		    Instantiate(particle, transform.position, Quaternion.identity);
	    }
	    
	    else if (coll.gameObject.CompareTag("Score50"))
	    {
		    Debug.Log("Score 50");
		    pinballManager.score += 50;
		    Instantiate(particle, transform.position, Quaternion.identity);
	    }
	    
	    if (coll.gameObject.CompareTag("Handle")
	        || coll.gameObject.CompareTag("Score10") || coll.gameObject.CompareTag("Score30")
	        || coll.gameObject.CompareTag("Score50"))
	    {
		    pinballManager.audioSource.Play();
	    }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
	    if (coll.gameObject.CompareTag("GameOver"))
	    {
		    gameOver = true;
		    Debug.Log("Game Over");
	    }
    }
}
