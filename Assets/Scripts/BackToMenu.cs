using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void buttonPress()
    {
      SceneManager.LoadScene("GameJOVER");
    }

 
  
        // Update is called once per frame
    void Update()
    {
        
    }
}
