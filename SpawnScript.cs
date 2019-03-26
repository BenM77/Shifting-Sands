//Ben Michael and Tristan Hildahl
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject Sand;
    public GameObject Water;
    public GameObject Mud;
    Vector3 originPosition;

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)//true while the touch is in any of the active phases
            {
                originPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 5));//to translate from screen position to world position
                switch (ParticleSelector.particleTypeNum)
                {
                    case 0:
                        Instantiate(Sand, originPosition, Quaternion.identity);//identity quaternion used for default rotation
                        break;
                    case 1:
                        Instantiate(Water, originPosition, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Mud, originPosition, Quaternion.identity);
                        break;
                }
            }
        }
    }
}
