using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncButton : MonoBehaviour
{

    public void SyncMethod()
    {
       string result = WikipediaRandomArticleGenerator.GetRandomArticle();
       Debug.Log(result);
    }


}
