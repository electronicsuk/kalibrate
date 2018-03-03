namespace KalibrateTest.BusinessLayer
{
    public interface IProduct :IQualityDeteriateStratergy
    {
        string Name { get; set; }
        int SellIn { get; set; }
        int Quality { get; set; }
        IQualityDeteriateStratergy stratergy { get; }
        void SetStratergy(IQualityDeteriateStratergy stratergy);
    }
}