namespace Models.Cargo
{
    /*export type PaginationResponseWithResults<R> = {
  page: string;
  totalPages: string;
  limit: string;
  results: R;
};
*/
    public class PaginationResponseWithResults<T>
    {
        public string Page { get; set; }
        public string TotalPage { get; set; }
        public string Limit { get; set; }
        public T Result { get; set; }
    }
}