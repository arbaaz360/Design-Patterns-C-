using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class PhotoProcessor
    {
        IFilter _filter { get; set; }
        ICompression _compression { get; set; }
        public PhotoProcessor(IFilter filter,ICompression compression)
        {
            this._compression = compression;
            this._filter = filter;
        }

        public void ProcessPhoto()
        {
            this._compression.Compress();
            this._filter.Apply();
        }
    }
}
