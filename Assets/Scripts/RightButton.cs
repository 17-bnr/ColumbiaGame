using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightButton : MonoBehaviour
{
    public Button rightb;

    // Start is called before the first frame update
    void Start()
    {
        rightb = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick(){
        if(GManager.instance.restart_flag==0){
            GManager.instance.restart_flag = 1;
            
            
            GManager.instance.player_num = 2;
            GManager.instance.text_mode = 1;
            
            Debug.Log("press up button");
        }
    }

    public void Active(){
        rightb.interactable = true;
    }

    public void Inactive(){
        rightb.interactable = false;
    }

}
