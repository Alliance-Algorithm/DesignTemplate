namespace 工厂模式;
interface ImageViewr
{
    public void ShowImage();
}

class NoTransport() : ImageViewr
{
    void ImageViewr.ShowImage()
    {
        Console.WriteLine("Using NoTransport");
    }
}
class XServerTransport() : ImageViewr
{
    void ImageViewr.ShowImage()
    {
        Console.WriteLine("Using XServerTransport");
    }
}
class ROSTransport() : ImageViewr
{
    void ImageViewr.ShowImage()
    {
        Console.WriteLine("Using ROSTransport");
    }
}

static class ImageViewrFactory
{
    public static ImageViewr Create(int type)
    {
        switch (type)
        {
            case 1:
                return new XServerTransport();
            case 2:
                return new ROSTransport();
            default:
                return new NoTransport();
        }
    }
}

// 选做：尝试添加一个新的转发算法
// 选做：使用枚举使代码更加稳定