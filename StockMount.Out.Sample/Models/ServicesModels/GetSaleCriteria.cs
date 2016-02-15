namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class GetSaleCriteria : CriteriaBase
    {
        public int StoreId { get; set; }
        public string OrderStatus { get; set; }
        public int SmallestOrderDetailId { get; set; }
        public int BiggestOrderDetailId { get; set; }
        public int RowsByPage { get; set; }
        public int PageIndex { get; set; }
    }
}