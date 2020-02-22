namespace OpenStore365.Serverless.Auth.AAD_B2C.Constants
{
    public static class EasyAuth
    {
        public static class HttpHeaders
        {
            private const string AAD_B2C_PREFIX = "X-MS-CLIENT-PRINCIPAL";
            public static string ID = $"{AAD_B2C_PREFIX}-ID";
            public static string DISPLAY_NAME = $"{AAD_B2C_PREFIX}-NAME";
        }
    }
}
