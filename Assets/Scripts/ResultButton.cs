using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButton : MonoBehaviour
{
    private bool resultButton = false;

    public void PressRestart(){
        Debug.Log("Press Start");
        if(!resultButton){
            Debug.Log("Go Next Scene!");
            SceneManager.LoadScene("Tittle");
            
            resultButton = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
