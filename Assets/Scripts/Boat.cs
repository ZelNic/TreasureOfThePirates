using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;

public class Boat : MonoBehaviour
{
    [Header("Set Dynamically")]
    public float rangePosBoat = 122f; // Расстояние, на котором управление лодки будет остановлено
    public Text scoreText;
    public int score;
    public int highScore;

    private void Start()
    {
        GameObject UIScore = GameObject.FindGameObjectWithTag("Score");
        scoreText = UIScore.GetComponent<Text>();
        scoreText.text = "0";
    }

    

    void Update()
    {
        Vector3 pos2DMouse = Input.mousePosition;
        pos2DMouse.z = -Camera.main.transform.position.z;
        Vector3 pos3DMouse = Camera.main.ScreenToWorldPoint(pos2DMouse);

        Vector3 posBoat = this.transform.position;
        posBoat.x = pos3DMouse.x;
        this.transform.position = posBoat;

    }

    public void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Bottle")
        {
            score = int.Parse(scoreText.text);
            score = score + 5;
            scoreText.text = score.ToString();
            Destroy(collidedWith);
        }
        
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }


    }



}

