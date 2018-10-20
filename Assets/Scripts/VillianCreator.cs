using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateVillians : MonoBehaviour {
   public GameObject villianCircle;
     public GameObject villianBox;
    public GameObject villianPentagon;
    public GameObject villianPentagon2;
    public float NextPos;
     public float LocationSend;
     float timer=0f;


     private void Start()
     {
        // Invoke("RepeatVillian",0f);
        CreateEnemy(50);
     }
    
    public void CreateEnemy(int number)
    {
        for (int i = 0; i < number; i++)
        {
            int rand = Random.Range(-1, 4);
            Vector3 pos = new Vector3(0, NextPos, 0);
            GameObject f1;
            switch (rand)
            {
                case 0:
                    f1 = Instantiate(villianCircle, pos, Quaternion.identity) as GameObject;
                    break;
                case 1:
                    f1 = Instantiate(villianBox, pos, Quaternion.identity) as GameObject;
                    break;
                case 2:
                    f1 = Instantiate(villianPentagon, pos, Quaternion.identity) as GameObject;
                    break;
                case 3:
                    f1 = Instantiate(villianPentagon2, pos, Quaternion.identity) as GameObject;
                    break;
                default:
                    f1 = Instantiate(villianBox, pos, Quaternion.identity) as GameObject;
                    break;
            }
            NextPos -= 4f;
        }
    }
}
