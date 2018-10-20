using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyNameSpace{ public class Colour : MonoBehaviour
        {
            public Rigidbody2D rb;
            public int currentColourCode;
            public SpriteRenderer sp;
            public Color ColourRed;
            public Color ColourYellow;
            public Color ColourPink;
            public Color ColourBlue;
            // Use this for initialization
            void Start()
            {
       
                SetRandomColour();
       
            }

            // Update is called once per frame
            void Update()
            {
       
            }
            public int GetCurrentColour()
            {
                return currentColourCode;
            }
   
            void SetRandomColour()
            {
                int index = Random.Range(0, 3);
                switch (index)
                {
                    case 0:
                        currentColourCode = 0; //Red
                        sp.color = ColourRed;
                        break;
                    case 1:
                        currentColourCode = 1; //Yellow
                        sp.color = ColourYellow;
                        break;
                    case 2:
                        currentColourCode = 2; //Pink
                        sp.color = ColourPink;
                        break;
                    case 3:
                        currentColourCode = 3; //Blue
                        sp.color = ColourBlue;
                        break;


                }
            }
        }
}
