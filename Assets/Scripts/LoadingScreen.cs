using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private List<FileLoader> fileloaders;
    [SerializeField] private Text text;

    public async void RunFileLoaders()
    {
        text.text = "Processing...";
        List<Task> tasks = new List<Task>();
        foreach (FileLoader loader in fileloaders)
        {
            Task task = loader.FileLoaderMethod(slider);
            tasks.Add(task);
        }
        await Task.WhenAll(tasks);
        text.text = "Done";
    }



}
