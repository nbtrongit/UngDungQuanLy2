
class Student
{
    #region Attributes
    private int _soTinChi;
    #endregion;

    #region Property
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public string Email { get; set; }
    public int SoTinChi { get { return _soTinChi; } set { if (value >= 0) { _soTinChi = value; } } }
    #endregion
    
    public void tinChiConThieu()
    {
        if(142 - this.SoTinChi >= 0)
        {
            Console.WriteLine($"Số tín chỉ còn thiếu {142 - this.SoTinChi}");
        }
    }
}
class Product
{
    #region Attibutes
    private float _gia;
    #endregion

    #region Property
    public string TenSanPham { get; set; }
    public float Gia { get { return _gia; } set { if (value >= 0) { _gia = value; } } }
    public int NamSanXuat { get; set; }
    public int HanSuDung { get; set; }
    #endregion
    public int HetHan()
    {
        return this.HanSuDung - DateTime.Now.Year;
    }
}