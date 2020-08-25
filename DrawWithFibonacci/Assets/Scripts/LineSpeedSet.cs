using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineSpeedSet : MonoBehaviour
{
    private HingeJoint2D hg;
    public string keySpeedName;

    public void Start()
    {
        hg = gameObject.GetComponent<HingeJoint2D>();
        JointMotor2D motor = hg.motor;
        motor.motorSpeed = PlayerPrefs.GetInt(keySpeedName);
        hg.motor = motor;
    }
}
