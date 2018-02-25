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
    public int columnZ = 2;
    public int columnA = 3;
    public int columnB = 4;
    public int columnC = 5;

    // Full column names
    public string xName;
    public string yName;
    public string zName;
    public string a;
    public string z;
    public string x;

    public float plotScale = 10;

    // The prefab for the data points that will be instantiated
    public GameObject PointPrefab;

    // Object which will contain instantiated prefabs in hiearchy
    public GameObject PointHolder;

    // Use this for initialization
    void Start()
    {

        // Set pointlist to results of function Reader with argument inputfile
        pointList = CSVReader.Read(inputfile);

        //Log to console
        Debug.Log(pointList);

        // Declare list of strings, fill with keys (column names)
        List<string> columnList = new List<string>(pointList[1].Keys);

        // Print number of keys (using .count)
        Debug.Log("There are " + columnList.Count + " columns in the CSV");

        for (int i = 0; i < 40; i++)
        {
            Debug.Log("lul"+pointList[i][xName]);
        }

        // Assign column name from columnList to Name variables
    }

}