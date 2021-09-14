﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models {
    public class PaginatedResponseModel<T> {
        const int MaxPageSize = 100;
        private int _pageSize ;
        public int PageSize {
            get => _pageSize;
            set => _pageSize = ( value > MaxPageSize ) ? MaxPageSize : value;
        }

        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public IList<T> Data { get; set; }

        public PaginatedResponseModel() {
            Data = new List<T>();
        }
    }
}
