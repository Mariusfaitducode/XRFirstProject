using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{

    public GameObject gameObjectToToggle; 

    public void Toggle()
    {
        
        if (gameObjectToToggle)
        {
            gameObjectToToggle.SetActive(!gameObjectToToggle.activeSelf);
        }
    }
}
