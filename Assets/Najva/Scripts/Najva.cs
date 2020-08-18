using UnityEngine;

namespace najva
{
	public class Najva : MonoBehaviour
	{

		private static NajvaAndroid mnajva;
		public static void init()
		{
			if (Application.isEditor)
            {
				return;
            }
			mnajva = new NajvaAndroid();
		}

		public static void SetUserHandler(UserCallback callback)
		{
			if (Application.isEditor)
			{
				return;
			}
			mnajva.SetUserHandler(callback);
		}

        public static void SetJsonHandler(JsonCallback callback)
        {
			if (Application.isEditor)
			{
				return;
			}
			mnajva.SetJsonCallback(callback);
        }

        public static string GetSubscribedToken()
        {
			if (Application.isEditor)
			{
				return "Editor token :)";
			}
			return mnajva.GetSubscribedToken();
        }

}


}