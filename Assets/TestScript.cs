using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
    public Material red;
    public Material white;
    string names;
    int countToggle = 0;
	public void Clicked(string name)
    { 
        names = name;
        Debug.LogError("You Clicked");
        //gameObject.GetComponent<MeshRenderer > ().material = red;
        GameObject.Find(name).GetComponent<MeshRenderer>().material = red;
    }

    private void Update()
    {
        if (countToggle>30)
        {
            Debug.LogError("Test in Update");
            GameObject.Find(names).GetComponent<MeshRenderer>().material = white;
            countToggle = 0;
        }
        else
        {
            countToggle++;
        }
    }
}
