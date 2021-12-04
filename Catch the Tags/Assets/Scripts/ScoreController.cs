﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    //public GameObject hat;

    public Text scoreText;

    private int score;

    // Update is called once per frame
    void Update()
    {
        // if (!hat)
        // {
        //   StartCoroutine()
        // }
        
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
      if (target.tag == "Bomb")
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }

    void OnTriggerExit2D(Collider2D target)
    {
      if (target.tag == "Fruit")
      {
        Destroy(target.gameObject);
        score++;
      }
    }

    // IEnumerator WaitTilRestart()
    // {
    //   yield return new WaitForSeconds(1.5f);
    //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }
}
