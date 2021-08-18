namespace Models.Cargo
{
    public class PaginationResponseWithResults<T>
    {
        public string Page { get; set; }
        public string TotalPage { get; set; }
        public string Limit { get; set; }
        public T Result { get; set; }
    }
}