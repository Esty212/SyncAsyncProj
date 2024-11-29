using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class FileLoader : MonoBehaviour
{
    [SerializeField] private int waitTime;
    [SerializeField] private string fileName;
    [SerializeField][Range(0, 1)] private float loadPart;

    public async Task FileLoaderMethod(Slider slider, CancellationToken token)
    {
        Debug.Log("started loading file with name " +  fileName);
        await Task.Delay(waitTime, token);
        slider.value += loadPart;
        Debug.Log("Ended loading file with name " + fileName);
    }

}
