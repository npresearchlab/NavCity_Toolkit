using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public TMP_InputField pID;
    public Button t1;
    public Button t2;
    public Button t3;
    public Button start;


    public static class Global
    {
        public static string ParticipantID;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(Button bt)
    {
        string trial = "";
        if (bt == t1)
        {
            trial = "t1";
        }
        else if (bt == t2)
        {
            trial = "t2";
        }
        else if (bt == t3)
        {
            trial = "t3";
        }
        Global.ParticipantID = pID.text + "_" + trial;
        Debug.Log(Global.ParticipantID);
    }
    public void toStart()
    {
        SceneManager.LoadScene("Spatial Nav Task");
    }
}
