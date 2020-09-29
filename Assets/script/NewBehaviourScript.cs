using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    GameObject plane;
    GameObject[] wall;
    GameObject dice;

    void start()
    {
        plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        wall = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            wall[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall[i].name = "wall" + i;
        }
        dice = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateEnvironment();
    }

    void CreateEnvironment()
    {
        SetPlane(plane);
        for (int i = 0; i < 4; i++)
        {
            SetWall(wall[i], i);
        }
        SetDice(dice);
    }
    void SetPlane(GameObject obj)
    {
        obj.transform.localPosition = Values1.plane_pos;
        //obj.transform.localRotation = Values.plane_rot;
        obj.transform.localScale = Values1.plane_scale;
    }

    void SetWall(GameObject obj, int index)
    {
        switch (index)
        {
            case 0:
                obj.transform.localPosition = Values1.cube1_pos;
                // obj.transform.localRotation = Values.cube1_rot;
                obj.transform.localScale = Values1.cube_scale;
                break;
            case 1:
                obj.transform.localPosition = Values1.cube2_pos;
                //obj.transform.localRotation = Values.cube2_rot;
                obj.transform.localScale = Values1.cube_scale;
                break;
            case 2:
                obj.transform.localPosition = Values1.cube3_pos;
                obj.transform.localScale = Values1.wall3and4;
                break;
            case 3:
                obj.transform.localPosition = Values1.cube4_pos;
                obj.transform.localScale = Values1.wall3and4;
                break;
        }
        obj.GetComponent<Renderer>().material.color = Color.blue;

    }

    void SetDice(GameObject obj)
    {
        obj.name = "dice";
        obj.transform.position = new Vector3(0f, 3.59f, 0.81f);
        obj.transform.Rotate(-45f, -50f, 40f);
        obj.GetComponent<Renderer>().material.color = Color.yellow;
        //obj.GetComponent<Rigidbody>();
    }
}
