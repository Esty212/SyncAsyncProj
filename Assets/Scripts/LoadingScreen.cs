using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private List<FileLoader> fileloaders;
    [SerializeField] private Text text;
    CancellationTokenSource cts = new CancellationTokenSource();
    [SerializeField] private bool isPressed = false;

    private async void RunFileLoaders()
    {
        text.text = "Processing...";
        List<Task> tasks = new List<Task>();
        foreach (FileLoader loader in fileloaders)
        {
            Task task = loader.FileLoaderMethod(slider, cts.Token);
            tasks.Add(task);
        }
        await Task.WhenAll(tasks);
        text.text = "Done";
    }

    private void CancelToken()
    {
        cts.Cancel();
        text.text = "Cancelled";
    }

    public void MyTest()
    {
        if (isPressed)
        {
            CancelToken();
        }
        else
        {
            isPressed = true;
            RunFileLoaders();
        }
    }



}
