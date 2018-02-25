using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour 
{
    public bool switchbool = false;
	public void Load(bool Practice) 
	{
        switchbool = Practice;
        Application.LoadLevel("Test");
    }
}
