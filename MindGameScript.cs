using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MindGameScript : MonoBehaviour
{
    private float angleFirst;
    private float angleSecond;
    private float angleThird;
    private float firstGearCheck = 91;
    private float secondGearCheck = 91;
    private float thirdGearCheck = 91;
    public float RotationSpeed;
    public Transform firstGear;
    public Transform secondGear;
    public Transform thirdGear;

    void Update()
    {
        InputButton();
        if (firstGearCheck <= 90)
        {
            angleFirst += Time.deltaTime * RotationSpeed;
            firstGearCheck += Time.deltaTime * RotationSpeed;
            firstGear.transform.rotation = Quaternion.Euler(0, 0, angleFirst);
        }
        if (secondGearCheck <= 90)
        {
            angleSecond += Time.deltaTime * RotationSpeed;
            secondGearCheck += Time.deltaTime * RotationSpeed;
            secondGear.transform.rotation = Quaternion.Euler(0, 0, angleSecond);
        }
        if (thirdGearCheck <= 90)
        {
            angleThird += Time.deltaTime * RotationSpeed;
            thirdGearCheck += Time.deltaTime * RotationSpeed;
            thirdGear.transform.rotation = Quaternion.Euler(0, 0, angleThird);
        }

    }

    void InputButton()
    {
        if (Input.GetKeyDown(KeyCode.W) && firstGearCheck > 90)
        {
            firstGearCheck = 0;
        }

        if (Input.GetKeyDown(KeyCode.E) && secondGearCheck > 90 && firstGearCheck > 90)
        {
            firstGearCheck = 0;
            secondGearCheck = 0;
        }

        if (Input.GetKeyDown(KeyCode.R) && secondGearCheck > 90 && firstGearCheck > 90 && thirdGearCheck > 90)
        {
            firstGearCheck = 0;
            secondGearCheck = 0;
            thirdGearCheck = 0;
        }
    }
}
