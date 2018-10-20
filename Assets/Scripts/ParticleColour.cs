using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 namespace MyNameSpace
{ public class ParticleColour : MonoBehaviour {

        public Colour ballcolour;
        public int value;
        public ParticleSystem ps;
        public Color startColor;
        //public SpriteRenderer rd;
        // Use this for initialization
        void Start () {
            var main = ps.main;
            value = ballcolour.GetCurrentColourCode(); //gets colour of the ball
            setParticlesColour(value, main);
            
	    }
        void setParticlesColour(int Case , ParticleSystem.MainModule main)
        {
            switch (Case)
            {
                case 0:
                    main.startColor = new Color(1, 0.04f, 0.18f, 1); //red
                    //rd.color = startColour;
                    break;
                case 1:
                    main.startColor = new Color(0.9f, 0.8f, 0.04f, 1f); //yellow
                                                                        // rd.color = startColour;
                    break;
                case 2:
                    main.startColor = new Color(0.9f, 0.04f, 0.6f, 1f); //pink
                    //rd.color = startColour;
                    break;
                case 3:
                    main.startColor = new Color(0, 0, 1, 1); //blue
                    break;

            }
        }
	
	    // Update is called once per frame
	    void Update () {
		
	    }
    }
}
