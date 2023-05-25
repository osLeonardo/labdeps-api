using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PortalTransparenciaDeps.Infrastructure.Excel
{
    public class ExcelFilters
    {
        private List<ExcelFilter> _filters = new();

        public ReadOnlyCollection<ExcelFilter> Filters => _filters.AsReadOnly();

        public ExcelFilters Add(string filterName, string filter)
        {
            var filterToAdd = new ExcelFilter(filterName, filter);

            _filters.Add(filterToAdd);

            return this;
        }

        public ExcelFilters AddWhen(string filterName, string filter, Func<bool> when)
        {
            if (when.Invoke())
            {
                var filterToAdd = new ExcelFilter(filterName, filter);

                _filters.Add(filterToAdd);
            }

            return this;
        }
    }

    public class ExcelFilter
    {
        public string Name { get; set; }
        public string Filter { get; set; }

        public ExcelFilter(string name, string filter)
        {
            Name = name;
            Filter = filter;
        }
    }
}
