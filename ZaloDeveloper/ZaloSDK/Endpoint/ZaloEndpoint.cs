using ZaloSDK.Config;

namespace ZaloSDK.Endpoint
{
    public class ZaloEndpoint
    {


        //  OA API ENDPOINT
        public static string GET_TAGS_ENDPOINT = getEndpoint("tag/gettagsofoa");
        public static string TAG_FOLLOWER_ENDPOINT = getEndpoint("tag/tagfollower");
        public static string REMOVE_TAG_ENDPOINT = getEndpoint("tag/rmtag");
        public static string REMOVE_FOLLOWER_FROM_TAG_ENDPOINT = getEndpoint("tag/rmfollowerfromtag");
        public static string SEND_TEXT_MESSAGE_ENDPOINT = getEndpoint("sendmessage/text");
        public static string SEND_IMAGE_MESSAGE_ENDPOINT = getEndpoint("sendmessage/image");
        public static string SEND_LINKS_MESSAGE_ENDPOINT = getEndpoint("sendmessage/links");
        public static string SEND_ACTION_MESSAGE_ENDPOINT = getEndpoint("sendmessage/actionlist");
        public static string SEND_STICKER_MESSAGE_ENDPOINT = getEndpoint("sendmessage/sticker");
        public static string SEND_GIF_MESSAGE_ENDPOINT = getEndpoint("sendmessage/gif");
        public static string GET_PROFILE_EDNPOINT = getEndpoint("getprofile");
        public static string UPLOAD_IMAGE_ENDPOINT = getEndpoint("upload/image");
        public static string UPLOAD_GIF_ENDPOINT = getEndpoint("upload/gif");

        public static string GET_MESSAGE_STATUS_ENDPOINT = getEndpoint("getmessagestatus");
        public static string REPLY_TEXT_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/text");
        public static string REPLY_IMAGE_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/image");
        public static string REPLY_LINKS_MESSAGE_ENDPOINT = getEndpoint("sendmessage/reply/links");
        public static string CREATE_QRCODE_ENDPOINT = getEndpoint("qrcode");

        private static string getEndpoint(string url)
        {
            return string.Format("{0}/{1}/{2}", APIConfig.DEFAULT_OA_API_BASE, APIConfig.DEFAULT_OA_API_VERSION, url);
        }

    }
}
