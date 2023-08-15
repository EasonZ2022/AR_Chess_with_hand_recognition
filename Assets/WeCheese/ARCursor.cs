using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    ARRaycastManager ar_raycast_manager;

    public Transform cursor; /* Change A */

    public TextMeshProUGUI Display1;

    void Start()
    {
        ar_raycast_manager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        Vector2 screen_center = new Vector2(Screen.width * 0.5f, Screen.height * 0.5f); /* Change B */
        List<ARRaycastHit> result_hits = new List<ARRaycastHit>(); /* Change C */

        ar_raycast_manager.Raycast(screen_center, result_hits); /* Change D */

        if (result_hits.Count > 0) /* Change E */
        {
            ARRaycastHit result = result_hits[0];
            cursor.SetPositionAndRotation(result.pose.position, result.pose.rotation);
            //Display1.text = string.Format("world : {0} {1} {2}", result.pose.position.x, result.pose.position.y, result.pose.position.z);
        }
    }
}






