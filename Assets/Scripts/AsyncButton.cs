using DefaultNamespace;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncButton : MonoBehaviour
{

    public async void AsyncMethod()
    {
        string res = await WikipediaRandomArticleGenerator.GetRandomArticleAsync();
        Debug.Log(res);
    }

}
