using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level4Done : MonoBehaviour
{
    public TargetCylinder block1;
    public TargetCylinder block2;
    public TargetCylinder block3;
    public TargetCylinder block4;
    public TargetCylinder block5;
    public TargetCylinder block6;

    public GameObject finalText;

    // Update is called once per frame
    void Update()
    {
        if (finalText == null)
        {
            return;
        }
        if (block1.good && block2.good && block3.good && block4.good && block5.good && block6.good)
        {


            finalText.SetActive(true);
        }
    }
}
