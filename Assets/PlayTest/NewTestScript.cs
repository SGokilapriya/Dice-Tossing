using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Tests
{
    public class NewTestScript
    {
        [SetUp]
        public void setup()
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

        [UnityTest]
        public IEnumerator SampleSceneIsLoaded()
        {
            Assert.AreEqual(SceneManager.GetActiveScene().name, "SampleScene");
            yield return null;
        }

        [UnityTest]
        public IEnumerator CanFindPlayerGameObject()
        {
            GameObject go = null;
            go = GameObject.Find("dice");
            Assert.NotNull(go);

            yield return null;
        }

        [UnityTest]
        public IEnumerator CheckingAddForce()
        {
            Vector3 before, after;
            GameObject dice = GameObject.Find("dice");
            before = dice.GetComponent<Transform>().position;

            Rigidbody rb;

            rb = dice.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, -500.0f, 0.0f) * 10);

            BoxCollider bc;

            bc = dice.GetComponent<BoxCollider>();

            yield return null;
            yield return null;
            yield return null;
            yield return null;

            after = dice.GetComponent<Transform>().position;
            Assert.AreNotEqual(before, after);
        }

        [UnityTest]
        public IEnumerator New_GameObject_WithRigidBody()
        {
            Vector3 before, after;
            GameObject gonew = GameObject.Find("Demo");
            before = gonew.GetComponent<Transform>().position;
            gonew.AddComponent<Rigidbody>();
            Rigidbody rb;
            rb = gonew.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f, -250.0f, 0.0f) * 10);

            yield return null;
            yield return null;
            yield return null;
            yield return null;

            after = gonew.GetComponent<Transform>().position;
            Assert.AreNotEqual(before, after);
        }
    
    }
}
