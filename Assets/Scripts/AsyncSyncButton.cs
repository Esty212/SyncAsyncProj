using DefaultNamespace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncSyncButton : MonoBehaviour
{
    public async void AsyncSyncMethod()
    {
        Task<string> task = new Task<string>(WikipediaRandomArticleGenerator.GetRandomArticle);
        task.Start();
        string result = await task;
        Debug.Log(result);
    }
}
