using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{

    public GameObject[] gameObjectToToggle; 

    public void Toggle()
    {
        
        if (gameObjectToToggle.Length > 0)
        {

            foreach(GameObject go in gameObjectToToggle)
            {
                go.SetActive(!go.activeSelf);

            }

        }
    }
}
