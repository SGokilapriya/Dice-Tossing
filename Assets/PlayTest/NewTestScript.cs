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
        [SetUp]
        public void setup()
        {
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }

        [UnityTest]
        public IEnumerator SceneIsLoaded()
        {
            Assert.AreEqual(SceneManager.GetActiveScene().name, "SampleScene");
            yield return null;
        }
      
        
    }
}
