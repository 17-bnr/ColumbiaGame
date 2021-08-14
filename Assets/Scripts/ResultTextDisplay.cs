using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultTextDisplay : MonoBehaviour
{
    private Text　message_text = null;
    // Start is called before the first frame update
    void Start()
    {
        message_text = GetComponent<Text>();
        message_text.text = DataSender.result_message;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
