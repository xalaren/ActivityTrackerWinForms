using System.Drawing.Text;

namespace ActivityTrackerWinForms.ActivityTrackerApp
{
    public class FontClass
    {
        public static PrivateFontCollection Font1 { get; private set; }
        public static PrivateFontCollection Font2 { get; private set; }
        public static PrivateFontCollection Font3 { get; private set; }

        public FontClass()
        {
            Files files = new Files();
            files.ToCatalog("Fonts");

            Font1 = new PrivateFontCollection();
            Font1.AddFontFile(files.DirectoryPath + @"\GoogleSans-Regular.ttf");
            Font2 = new PrivateFontCollection();
            Font2.AddFontFile(files.DirectoryPath + @"\GoogleSans-Medium.ttf");
            Font3 = new PrivateFontCollection();
            Font3.AddFontFile(files.DirectoryPath + @"\GoogleSans-Bold.ttf");
        }
    }
}
