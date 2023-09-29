using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Linq;
using System.IO;

public class Info_input : MonoBehaviour
{
    public InputField input_trials;
    public InputField input_id;
    public Button submit;
    public GameObject info_object;
    public GameManager info;

    private static string trials;
    private static string id;


    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(info_object);
        input_trials.onEndEdit.AddListener(SubmitTrials);
        input_id.onEndEdit.AddListener(SubmitID);
        Button button = submit.GetComponent<Button>();
        button.onClick.AddListener(SceneTransition);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SubmitTrials(string trials)
    {
        info.trials = trials;

    }

    private void SubmitID(string ID)
    {
        info.id = ID;

    }


    private void SceneTransition()
    {
        SceneManager.LoadScene("SpatialNavTask");
    }


}
