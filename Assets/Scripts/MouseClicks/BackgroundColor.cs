using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MouseClicks
{
    public class BackgroundColor : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            var renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                if (GameData.Instance.activeBackground == this)
                {
                    renderer.material.color = new Color(0.3f, 0.3f, 0.3f);
                } else
                {
                    renderer.material.color = new Color(0.5f, 0.5f, 0.5f);
                }
            } else
            {
                Debug.Log("no renderer");
            }
            
        }

        private void OnMouseDown()
        {
            GameData.Instance.activeBackground = this;
        }
    }
}

