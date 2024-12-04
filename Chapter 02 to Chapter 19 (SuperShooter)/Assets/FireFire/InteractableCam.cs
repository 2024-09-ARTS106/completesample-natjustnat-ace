using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCam : MonoBehaviour
{
    [SerializeField]
    Camera playerCam;
    [SerializeField]
    float seeDistance;
    [SerializeField]
    LayerMask interactble;
    [SerializeField]
    Canvas InteractUI;

    private void Update()
    {
        Ray ray = new Ray(playerCam.transform.position, playerCam.transform.forward);
        Debug.DrawRay(playerCam.transform.position, playerCam.transform.forward, Color.red);

        if (Physics.Raycast(ray, out RaycastHit hit, seeDistance, interactble))
        {
            InteractUI.enabled = true;
            if (Input.GetButtonDown("Interact"))
            {
                hit.transform.gameObject.GetComponent<Switch>().callSwitch();
            }
        }
        else 
        {
            InteractUI.enabled = false;
        }
    }
}
