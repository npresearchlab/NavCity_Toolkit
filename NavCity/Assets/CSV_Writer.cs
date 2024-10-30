// This script is written in C# and is intended to be used in conjunction with the Unity game engine.
// The purpose of this script is to write information about a participant's experience during a maze task to a CSV
// (comma-separated values) file.


using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System;
public class CSV_Writer : MonoBehaviour
{
    /*The script declares several public and private variables (ParticipantID, HeadsetTransform,
    RotationTransform, rowData, initialized, seconds, seconds2, frames, line, record, and outStream).
    ParticipantID is a string that identifies the participant whose data is being recorded. This is input 
    by the administrater of the task. HeadsetTransform and RotationTransform are Transform objects that store 
    positional and rotational information of the participant's head during the maze task. rowData is a List of string 
    arrays that stores the data that will be written to the CSV file. initialized is a boolean that tracks whether the 
    InitSave() method has already been called. seconds, seconds2, and frames are floats and integers that track the 
    duration and number of frames elapsed during the maze task. line is a string that represents a single row of data 
    in the CSV file. record is a boolean that tracks whether the script should be actively recording data to the CSV 
    file. outStream is a StreamWriter object that is used to write data to the CSV file.*/

    public string ParticipantID;
    public Transform HeadsetTransform;
    public Transform RotationTransform;
    private List<string[]> rowData = new List<string[]>();
    bool initialized = false;

    /*The following portion of the script then defines several methods (Start(), Update(), InitSave(), Save(), getPath(), ResetTimer(), 
    StopSave(), and OnDestroy()).*/

    //Start() is called once when the script is first loaded. It initializes the CSV file and begins recording data.
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

    // Update() is called every frame and checks whether record is true, and if it is, Save() is called.
    private void Update()
    {
        if (record)
        {
            this.Save();
        }
    }
    
    private StreamWriter outStream;

    /*The script defines the structure of the CSV file with 10 columns, each containing specific information about the 
    participant and the session.The header row is defined in the InitSave() method and each column's content is defined 
    in the Save() method. The columns contain the following information: ParticipantID, X coordinate of the 
    HeadsetTransform position, Z coordinate of the HeadsetTransform position, Frame number, Total Time elapsed, 
    Lapsed Time elapsed, Target Name, X Euler Angle of the RotationTransform, Y Euler Angle of the RotationTransform, 
    and Z Euler Angle of the RotationTransform.*/

    

    //InitSave() initializes the CSV file by defining the header row and creating the file on the machine's desktop. 
    void InitSave(){
        initialized = true;

        // Defining header row for the CSV file, containing the following 10 items
        string[] rowDataTemp = new string[10];
        rowDataTemp[0] = "ParticipantID";
        rowDataTemp[1] = "X";
        rowDataTemp[2] = "Z";
        rowDataTemp[3] = "Frame";
        rowDataTemp[4] = "Total Time";
        rowDataTemp[5] = "Lapsed Time";
        rowDataTemp[6] = "Target Name";
        rowDataTemp[7] = "X Euler Angle";
        rowDataTemp[8] = "Y Euler Angle";
        rowDataTemp[9] = "Z Euler Angle";

        // Filling in CSV file with the defined header items
        int length = 10;
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
    /*Save() is responsible for collecting the data from the maze task and writing it to the CSV file. getPath() returns
    the path to the CSV file.*/

    string[] rowDataWorking = new string[10];
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
        rowDataWorking[7] = RotationTransform.localRotation.eulerAngles.ToString();



        // Filling in CSV file with the defined row items above (collected data)
        int length = 8;
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

    /*ResetTimer() resets the duration timer to zero.StopSave() is called when the maze task is complete and it 
    closes the CSV file.*/
    public void ResetTimer()
    {
        seconds = 0;
    }

    // Closing the CSV file
    void StopSave()
    {
        outStream.Close();
    }

    //OnDestroy() is called when the script is destroyed and it calls StopSave() to ensure that the CSV file is closed
    private void OnDestroy()
    {
        StopSave();
    }
    
}
