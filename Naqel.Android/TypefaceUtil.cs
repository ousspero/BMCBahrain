using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using Java.Lang;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace BMSBahrain.Droid
{
    public class TypefaceUtil
    {

        /**
         * Using reflection to override default typeface
         * NOTICE: DO NOT FORGET TO SET TYPEFACE FOR APP THEME AS DEFAULT TYPEFACE WHICH WILL BE OVERRIDDEN
         * @param context to work with assets
         * @param defaultFontNameToOverride for example "monospace"
         * @param customFontFileNameInAssets file name of the font from assets
         */
        public static void overrideFont(AssetManager assets, string defaultFontNameToOverride, string customFontFileNameInAssets)
        {
            try
            {
                var typeFace = Class.FromType(typeof(Typeface));
                var customfont = Typeface.CreateFromAsset(assets, customFontFileNameInAssets);
                var font = typeFace.GetDeclaredField(defaultFontNameToOverride);

                font.Accessible = true;
                font.Set(null, customfont);
            }
            catch (System.Exception e)
            {
                var error = e.Message;
            }
        }
    }
}