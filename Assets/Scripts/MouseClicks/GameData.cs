using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MouseClicks
{
    public class GameData
    {
        public Vector3 MousePos { get; set; }
        public BackgroundColor activeBackground { get; set; }

        private GameData() { }

        private static GameData instance;
        public static GameData Instance
        {
            get
            {
                if (instance == null) instance = new GameData();
                return instance;
            }
        }
    }
}

