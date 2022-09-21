using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosToText : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI textField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (textField != null)
        {
            var pos = new Vector2(GameData.Instance.MousePos.x, GameData.Instance.MousePos.y);

            textField.text = pos.ToString();
        }
    }
}
