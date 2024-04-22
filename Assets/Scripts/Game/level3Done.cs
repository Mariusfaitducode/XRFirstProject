using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3Done : MonoBehaviour
{
    public MatchBlockAndSphere block1;
    public MatchBlockAndSphere block2;
    public MatchBlockAndSphere block3;

    public GameObject button;

    // Update is called once per frame
    void Update()
    {
        if (button == null || block1 == null || block2 == null || block3 == null)
        {
            return;
        }
        if (block1.good &&  block2.good && block3.good) {
            

            button.SetActive(true);
        }
    }
}
