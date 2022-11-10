using System.Threading.Tasks;

namespace TapTap.RTC
{
    public class TapRTC
    {
        public static Task<ResultCode> Init(TapRTCConfig config)
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().Init(config);
#else
            throw new System.NotImplementedException();
#endif
        }

        public static ResultCode UnInit()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().UnInit();
#else
            throw new System.NotImplementedException();
#endif
        }

        public static ITapRTCAudioDevice GetAudioDevice()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().GetAudioDevice();
#else
            throw new System.NotImplementedException();
#endif
        }

        public static ITapRTCRoomDelegate AcquireRoom(string roomId, bool rangeAudio = false)
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().AcquireRoom(roomId, rangeAudio);
#else
            throw new System.NotImplementedException();
#endif
        }

        public static ResultCode Poll()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().Poll();
#else
            throw new System.NotImplementedException();
#endif
        }

        public static ResultCode Resume()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().Resume();
#else
            throw new System.NotImplementedException();
#endif
        }


        public static ResultCode Pause()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCDelegateImpl.GetInstance().Pause();
#else
            throw new System.NotImplementedException();
#endif
        }

        public static string GetVersion()
        {
#if UNITY_IOS || UNITY_ANDROID
            return TapRTCConstants.VERISON;
#else
            throw new System.NotImplementedException();
#endif
        }
    }
}
