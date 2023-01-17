using System.Runtime.InteropServices;

namespace imadake398yen
{
    public class ScreenRecordingDetection
    {
#if UNITY_IOS && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern bool screenRecordingDetection_isCaptured();
#endif

        public static bool IsCaptured()
        {
#if UNITY_IOS && !UNITY_EDITOR
            return screenRecordingDetection_isCaptured();
#endif
            return false;
        }
    }
}