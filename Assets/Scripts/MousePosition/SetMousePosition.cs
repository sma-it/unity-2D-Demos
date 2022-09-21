using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMousePosition : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        GameData.Instance.MousePos = mousePosition;
    }
}
