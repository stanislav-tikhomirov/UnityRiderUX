using System.Collections;
using System.Collections.Generic;
using BaseScripts;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class AppControlIsPresent
    {
        [Test]
        public void AppControlIsPresentSimplePasses()
        {
            EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity");
            Assert.IsNotNull(GameObject.Find("AppContro"));
        }
    }
}
