using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Tests
{
    public class NewTestScript
    {
        GameObject plane;
        GameObject[] wall;
        GameObject dice;

        [SetUp]
        public void setup()
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
            obj.transform.localPosition = Values.plane_pos;
            //obj.transform.localRotation = Values.plane_rot;
            obj.transform.localScale = Values.plane_scale;
        }

        void SetWall(GameObject obj, int index)
        {
            switch (index)
            {
                case 0:
                    obj.transform.localPosition = Values.cube1_pos;
                   // obj.transform.localRotation = Values.cube1_rot;
                    obj.transform.localScale = Values.cube_scale;
                    break;
                case 1:
                    obj.transform.localPosition = Values.cube2_pos;
                    //obj.transform.localRotation = Values.cube2_rot;
                    obj.transform.localScale = Values.cube_scale;
                    break;
                case 2:
                    obj.transform.localPosition = Values.cube3_pos;
                    obj.transform.localScale = Values.wall3and4;
                    break;
                case 3:
                    obj.transform.localPosition = Values.cube4_pos;
                    obj.transform.localScale = Values.wall3and4;
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

        [UnityTest]
        public IEnumerator MoveFront()
        {
        
            yield return null;
            yield return null;
            
        }
    }
}
