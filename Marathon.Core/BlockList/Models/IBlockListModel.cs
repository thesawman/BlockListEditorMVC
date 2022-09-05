using Umbraco.Cms.Core.Strings;

namespace Marathon.Core.BlockList.Models
{
    public interface IBlockListModel
    {
        CommonSettingsModel? CommonSettings { get; set; }

    }
}