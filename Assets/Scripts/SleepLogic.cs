using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

namespace DefaultNamespace
{
    public class SleepLogic : MonoBehaviour
    {
        [SerializeField] private float _timeToSleep = 1f;
        [SerializeField] private Button _button;
        [SerializeField] private Text _textField;
        
        private void Awake()
        {
            //_button.onClick.AddListener(OnClick);
        }
        
        private void OnClick()
        {
           _textField.text = "processing...";
           LongRunningOperation();
            _textField.text = "done";
        }
        
        private void LongRunningOperation()
        {
            Thread.Sleep(TimeSpan.FromSeconds(_timeToSleep));
        }
    }
}