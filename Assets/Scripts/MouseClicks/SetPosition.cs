using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MouseClicks
{
    public class SetPosition : MonoBehaviour
    {
        [SerializeField] bool onDrag;
        [SerializeField] int button;

        private float dragTime = 0;

        // Update is called once per frame
        void Update()
        {
            updateDragTime();
            if (onDrag)
            {
                if (isDragging())
                {
                    transform.position = GameData.Instance.MousePos;
                }
            } else
            {
                if (isReleasing())
                {
                    transform.position = GameData.Instance.MousePos;
                }
            }
        }

        void updateDragTime()
        {
            if (Input.GetMouseButton(button))
            {
                dragTime += Time.deltaTime;
            }
            else if (Input.GetMouseButtonUp(button)) // cannot use buttondown because we don't know about dragging at that point
            {
                if(!onDrag && !isDragging())
                {
                    dragTime = -1; // set to -1 for one frame, will be set to 0 in the next update
                }            
            } else
            {
                dragTime = 0;
            }
        }

        bool isDragging()
        {
            return dragTime > 0.2;
        }

        bool isReleasing()
        {
            return dragTime < 0;
        }
    }
}

