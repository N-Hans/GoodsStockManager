using System.ComponentModel;

namespace GoodsStockManager.API.Data.Enumerations
{
    public enum GoodsItemManagementTypes {
        [Description("None")]
        None,

        [Description("Serial Number")]
        SerialNumber,

        [Description("Batch Number")]
        BatchNumber
    }
}
