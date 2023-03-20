using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BottlePicker : MonoBehaviour
{
    public int countLive = 3;
    public Text countLiveText;
    
    private void Start()
    {
        GameObject liveCount = GameObject.FindGameObjectWithTag("Live");
        countLiveText = liveCount.GetComponent<Text>();
        countLiveText.text = "3";
    }
   
    public void ItakeYourHarts()
    {
        
        countLive = int.Parse(countLiveText.text);
        countLive--;
        countLiveText.text = countLive.ToString();
        
        if (countLive == 0)
        {
            SceneManager.LoadScene("GameOver");
            
        }
    }
    

}
