using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace imadake398yen
{
    public class Demo : MonoBehaviour
    {
        [SerializeField] private Text testLabel;

        private IEnumerator Start()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);
                testLabel.text = $"isCaptured: {ScreenRecordingDetection.IsCaptured()}";
            }
        }

    }
}