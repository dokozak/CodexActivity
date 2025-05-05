using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class GuyTest
{
    private GameObject Guy;
    private GameObject Ground;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator GuyTouchFloor()
    {   
        yield return new WaitForSeconds(2);
        Guy = GameObject.Find("Guy");
        Ground = GameObject.Find("Ground");
       


        Assert.That(Guy.transform.position.y > Ground.transform.position.y);
       
    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}
