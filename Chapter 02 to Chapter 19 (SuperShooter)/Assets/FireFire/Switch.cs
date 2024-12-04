using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField]
    string methodName;
    [SerializeField]
    SwitchManager switchManager;

    private void Awake()
    {
        switchManager = GetComponentInParent<SwitchManager>();
    }
    public void callSwitch()
    {
        switchManager.TriggerAction(methodName);
    }
}
