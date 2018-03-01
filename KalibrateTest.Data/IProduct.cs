namespace KalibrateTest.Data
{
    public interface IProduct
    {
        string Name { get; set; }
        int SellIn { get; set; }
        int Quality { get; set; }

        string QualityControl();
        string Print();
    }
}