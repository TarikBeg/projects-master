namespace SharedKernel.ApiModels
{
    public class PagingInfo
    {
        private const int DefaultPageSize = 50;
        private const int DefaultPageNumber = 1;

        public PagingInfo(int pageNumber = DefaultPageNumber, int pageSize = DefaultPageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            SetSkipSize();
        }

        public PagingInfo(PaginationInfo model)
        {
            PageNumber = model.Page;
            PageSize = model.PageSize;
            SetSkipSize();
        }

        private int _pageNumber;
        public int PageNumber
        {
            get => _pageNumber;
            private init
            {
                if (value <= 0)
                    value = DefaultPageNumber;
                _pageNumber = value;
            }
        }

        private int _pageSize;
        public int PageSize
        {
            get => _pageSize;
            private init
            {
                if (value <= 0)
                    value = DefaultPageSize;
                _pageSize = value;
            }
        }

        public int SkipSize { get; private set; }

        public int GetDefaultPageSize() => DefaultPageSize;
        public int GetDefaultPageNumber() => DefaultPageNumber;
        private int SetSkipSize() => SkipSize = _pageSize * (_pageNumber - 1);
    }
}