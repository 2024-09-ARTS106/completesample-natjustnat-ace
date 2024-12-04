using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notescript : MonoBehaviour
{
    private void Update()
    {
        closeUI();
    }
    public void closeUI()
    {
        if(Input.GetKeyDown(KeyCode.Q)) this.gameObject.SetActive(false);
    }
}
