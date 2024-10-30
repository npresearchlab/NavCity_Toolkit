using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
public class CSV_Writer : MonoBehaviour
{
    public string ParticipantID;
    public Transform HeadsetTransform;
    private List<string[]> rowData = new List<string[]>();
    bool initialized = false;

    void Start ()
    {
       if (!initialized)
        {
            InitSave();
            Save();
        }
        
    }

    private float seconds;
    private float seconds2;
    private int frames;
    private string line;
    private bool record;

    private void Update()
    {
        if (record)
        {
            this.Save();
        }
    }
    
    private StreamWriter outStream;

    // This code below sets the content for each column of the CSV file that this code writes to.
    // There are 7 columns in this CSV file that contain specific information about the participant and the session.

    void InitSave(){
        initialized = true;

        // Defining header row for the CSV file, containing the following 7 items
        string[] rowDataTemp = new string[7];
        rowDataTemp[0] = "ParticipantID";
        rowDataTemp[1] = "X";
        rowDataTemp[2] = "Z";
        rowDataTemp[3] = "Frame";
        rowDataTemp[4] = "Total Time";
        rowDataTemp[5] = "Lapsed Time";
        rowDataTemp[6] = "targetName";

        // Filling in CSV file with the defined header items
        int length = 7;
        string delimiter = ",";
        for (int index = 0; index < length; index++)
        {
            if(index > 0) {line += delimiter;}

            line += rowDataTemp[index]; 
        }

        // Creating the CSV file that will be recorded to on this machine's desktop
        string filePath = getPath();
        outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(line);
        seconds = 0;
        seconds2 = 0;
        frames = 0;
        record = true;
    }
    
    // Now, this code below sets how information will be retreived and recorded from the maze task.  

    string[] rowDataWorking = new string[7];
    void Save(){
        // Setting pathways for retrieving the collected data for each column
        rowDataWorking[0] = ParticipantID;
        rowDataWorking[1] = HeadsetTransform.position.x.ToString();
        rowDataWorking[2] = HeadsetTransform.position.z.ToString();
        rowDataWorking[3] = (frames++).ToString();
        seconds2 = (float)(seconds2 + (Time.deltaTime * 1));
        rowDataWorking[4] = seconds2.ToString();
        seconds = (float)(seconds +(Time.deltaTime*1));
        rowDataWorking[5] = seconds.ToString();
        rowDataWorking[6] = GetComponent<TargetManager>().targets[TargetManager.targetNum].name;

        // Filling in CSV file with the defined row items above (collected data)
        int length = 7;
        string delimiter = ",";
        line = "";
        for (int index = 0; index < length; index++)
        {
            if(index > 0) {line += delimiter;}
            line += rowDataWorking[index];
        }

        // Writing to the CSV file that is being recorded to on this machine's desktop
        string filePath = getPath();
        outStream.WriteLine(line);
    }

    

    // The following methods perform actions to locate the CSV file and conclude the session.

    // Retrieving path to the CSV file on this machine
    private string getPath(){
        #if UNITY_EDITOR
        return Application.dataPath +"/CSV/"+"Saved_data_"+ ParticipantID + ".csv";
        #else
        return Application.dataPath +"/"+"Saved_data.csv";
        #endif
    }

    // Resetting timer that collects task data
    public void ResetTimer()
    {
        seconds = 0;
    }

    // Closing the CSV file
    void StopSave()
    {
        outStream.Close();
    }
    private void OnDestroy()
    {
        StopSave();
    }
    
}
