using Marathon.Core.BlockList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Core.BlockList.Common.Helper
{
    public static class BLHelper
    {
        public static string CommonClasses(CommonSettingsModel settings)
        {
            return $"tm{settings.TopMargin?.Replace(" ", "")} bm{settings.BottomMargin?.Replace(" ", "")} {(settings.FullWidth ? "fullwidth" : "")} mw{settings.MaxWidth?.Replace(" ", "")}";

        }
    }
}
