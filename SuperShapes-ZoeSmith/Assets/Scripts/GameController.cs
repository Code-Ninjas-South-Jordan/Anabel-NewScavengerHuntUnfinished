﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

[Header("Game Over UI Object")]
public GameObject gameOverCanvas;
[Header("Shape Objects")]
public GameObject[] shapePrefabs;
[Header("Default Spawn Delay Time")]
public float spawnDelay = 2f;
[Header("Default Spawn Time")]
public float spawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    // Update is called once per frame
    public void GameOver()
    {
        CancelInvoke("Spawn");
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }
            
    
}
