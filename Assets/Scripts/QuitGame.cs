using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {
	void Update() 
	{
		if (Input.GetKey("escape"))
			Application.Quit();

	}
}