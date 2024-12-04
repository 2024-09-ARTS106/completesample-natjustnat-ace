//using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SwitchManager : MonoBehaviour
{
    private Dictionary<string, Action> methods = new Dictionary<string, Action>();

    [Header("ShowPageOne Variables")]
    [SerializeField]
    GameObject pageUI1;

    private void Awake()
    {
        // Register methods
        methods.Add("ShowPageOne", ShowPageOne);
        // Add more methods as needed

    }
    public void TriggerAction(string methodName)
    {
        if (methods.TryGetValue(methodName, out Action method))
        {
            method.Invoke();
        }
        else
        {
            Debug.LogWarning($"Method '{methodName}' not found in SwitchManager.");
        }
    }
    void ShowPageOne()
    {
        pageUI1.SetActive(true);
    }
}
