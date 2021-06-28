using System;

namespace Adapter
{
    public class Image
    {
        public string Name { get; set; }
    }

    public class ImageViewer
    {
        private Image image { get; set; }
        public ImageViewer(Image image)
        {
            this.image = image;
        }
        public void Apply(IFilter filter)
        {
            filter.apply(image);
        }
    }

    public class SepiaFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Sepia Filter..");
        }
    }

    public interface IFilter
    {
        void apply(Image image);
    }

    public class FancyFilter
    {
        internal void render(Image image)
        {
            Console.WriteLine("Applying fancy filter..");
        }
    }

    public class FancyAdapter : IFilter
    {
        FancyFilter filter { get; set; }
        public FancyAdapter(FancyFilter filter)
        {
            this.filter = filter;
        }
        public void apply(Image image)
        {
            this.filter.render(image);
        }
    }
}
