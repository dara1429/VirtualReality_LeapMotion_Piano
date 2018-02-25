using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestCSVReader : MonoBehaviour
{

    // Name of the input file, no extension
    public string inputfile;

    // List for holding data from CSV reader
    private List<Dictionary<string, object>> pointList;

    // Indices for columns to be assigned
    public int columnX = 0;
    public int columnY = 1;


    // Full column names
    public string xName;
    public string yName;

    private Boolean keyChange = true;
    private int count = 0;
    private int delayCounter = 0;

    public Material white;
    public Material green;

    public Boolean playSong;

    public LoadLevel load;

    // Use this for initialization
    void Start()
    {
        readCSV();
    }

    private void Update()
    {
        if (playSong)
        {
            if (delayCounter < 60)
            {
                if (keyChange)
                {
                    GameObject.Find(pointList[count][xName] + "5").GetComponent<MeshRenderer>().material = green;
                    keyChange = false;
                    if (count != 0)
                    {
                        GameObject.Find(pointList[count - 1][xName] + "5").GetComponent<MeshRenderer>().material = white;
                    }
                    Debug.LogError("Inside Update");
                    count++;
                }
                delayCounter++;
                keyChange = false;
            }
            else
            {
                keyChange = true;
                delayCounter = 0;
            }
            if (count == pointList.Count)
            {
                count = 0;
            }
        }
    }

    private void readCSV()
    {
        // Set pointlist to results of function Reader with argument inputfile
        pointList = CSVReader.Read(inputfile);

        //Log to console
        Debug.Log(pointList);

        Debug.LogError(playSong);

        // Declare list of strings, fill with keys (column names)
        List<string> columnList = new List<string>(pointList[1].Keys);

        xName = columnList[columnX];
        yName = columnList[columnY];
        Debug.LogError(pointList[1][yName]);


        // Print number of keys (using .count)
        Debug.Log("There are " + columnList.Count + " columns in the CSV");

        // Assign column name from columnList to Name variables
    }
}