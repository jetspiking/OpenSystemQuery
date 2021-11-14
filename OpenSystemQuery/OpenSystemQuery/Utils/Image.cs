using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;
using System.Diagnostics;

namespace OpenSystemQuery.Utils
{
    public static class Image
    {
        public enum IconImages
        {
            AddCategory,
            AddFile,
            AnnotationsHelp,
            AnnotationsInfo,
            AnnotationsWarning,
            ArrowReturnLeftBlue,
            ArrowReturnRightBlue,
            Close,
            Colorize,
            Delete,
            Edit,
            FullView,
            GetPermission,
            Options,
            OverlayAudio,
            OverlayShare,
            PendingRequest,
            PrintView,
            QuestionBlue,
            QuestionRed,
            RefreshArrowBlue,
            RefreshArrowGreen,
            UpFolder,
            ZoomIn,
            ZoomOut
        }

        public enum AppImages
        {
            OpenSystemQueryDark
        }

        public static BitmapImage GetIconImage(IconImages image)
        {
            return new BitmapImage(new Uri("Resources/Icons/" + image.ToString() + ".png", UriKind.RelativeOrAbsolute));
        }

        public static BitmapImage GetImage(AppImages image)
        {
            return new BitmapImage(new Uri("Resources/Images/" + image.ToString() + ".png", UriKind.RelativeOrAbsolute));
        }
    }
}
