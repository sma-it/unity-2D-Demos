using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosToText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var field = GameObject.FindObjectOfType<TMPro.TextMeshProUGUI>();
        if (field != null)
        {
            var pos = new Vector2(GameData.Instance.MousePos.x, GameData.Instance.MousePos.y);

            field.text = pos.ToString();
        }
    }
}
