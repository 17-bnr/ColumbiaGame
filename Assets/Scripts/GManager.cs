using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;
    public int player_num = 0;
    public int dealer_num = 0;
    public int text_mode = 0;
    public int takamina_mode = 0;
    public int oonisi_mode = 0;
    public int restart_flag = 0;

    public int victory_count = 0;

    private void Awake(){
        if(instance==null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else
        {
            Destroy(this.gameObject);
        }
    }

    public void Init(){
        if(instance!=null){
            player_num = 0;
            dealer_num = 0;
            text_mode = 0;
            takamina_mode = 0;
            restart_flag = 0;
            victory_count = 0;
        }
    }

    public void GameOver(string _result_message){
        DataSender.result_message = _result_message;
        SceneManager.LoadScene("Result");
        GManager.instance.Init();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(game_over_flag==1){
            Init();
        }*/
    }
}
