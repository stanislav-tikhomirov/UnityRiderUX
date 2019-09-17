using BaseScripts;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class PlayerCubeFliesAtHit
    {
        [UnityEngine.TestTools.UnityTest]
        public System.Collections.IEnumerator PlayerCubeFliesAtHitWithEnumeratorPasses()
        {
            SceneManager.LoadScene("SampleScene");
            yield return null;
            AppControl.instance.player.Initialize();
            while (Time.time < 10f)
            {
                yield return null;
            }
            Assert.AreNotEqual( AppControl.instance.player.cubeT.gameObject.GetComponent<Rigidbody>().velocity, Vector3.zero);
        }
    }
}