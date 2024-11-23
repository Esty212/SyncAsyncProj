using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

namespace DefaultNamespace
{
    public class SleepLogicAsync : MonoBehaviour
    {
        [SerializeField] private float _timeToSleep = 1f;
        [SerializeField] private Button _button;
        [SerializeField] private Text _textField;
        
        private void Awake()
        {
            _button.onClick.AddListener(OnClick);
        }
        
        private async void OnClick()
        {
           _textField.text = "processing...";
           await LongRunningOperation();
            _textField.text = "done";
        }
        
        private async Task LongRunningOperation()
        {
            await Task.Delay(TimeSpan.FromSeconds(_timeToSleep));
        }
    }
}