using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
public class MusicBox : MonoBehaviour
{
    public TMP_Text musicText;
    bool canSeeBox;
    int secondsLeft = 30;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Countdown", 1, 1);
        InvokeRepeating("CountUp", 1, 0.25f);
    }
    void Countdown()

    {
        secondsLeft --;
        musicText.text = secondsLeft.ToString();
        if (secondsLeft == 0)
        {
            SceneManager.LoadScene("Main Menu");
        }
        //If seconds >0 gameover 
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void CountUp()

    {
        if (canSeeBox && Input.GetKey(KeyCode.E) && secondsLeft < 30)
        {
            secondsLeft++;
            musicText.text = secondsLeft.ToString();
            //click e to incress time
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canSeeBox = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canSeeBox = false;
        }
    }
}
