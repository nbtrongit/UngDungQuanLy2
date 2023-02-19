using System;

var rng = new Random();

Hinh hinh;
List<Hinh> DsHinh = new List<Hinh>();
for (int i = 1; i <= 20; i++)
{
    if(rng.Next(1,4) == 1)
    {
        hinh = new HinhTron(rng.Next(1, 100));
    }
    else if (rng.Next(1, 4) == 2)
    {
        hinh = new HinhChuNhat(rng.Next(1, 100), rng.Next(1, 100));
    }
    else
    {
        hinh = new HinhVuong(rng.Next(1, 100));
    }
    DsHinh.Add(hinh);
}

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"Hình {i + 1}");
    Console.WriteLine($"Diện tích {DsHinh[i].DienTich()}");
    Console.WriteLine($"Chu vi {DsHinh[i].ChuVi()}");
}
abstract class Hinh
{
    public abstract double ChuVi();
    public abstract double DienTich();
}
/*interface Hinh
{
    public abstract double ChuVi();
    public abstract double DienTich();
}*/
class HinhTron : Hinh
{
    public double BanKinh { get; set; }
    public HinhTron(double banKinh)
    {
        this.BanKinh = banKinh;
    }

    public override double ChuVi() => this.BanKinh * 2 * 3.14;
    public override double DienTich() => this.BanKinh * this.BanKinh * 3.14;
}
class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }
    public HinhChuNhat(double dai, double rong)
    {
        this.Dai = dai;
        this.Rong = rong;
    }

    public override double ChuVi() => (this.Dai + this.Rong) * 2;
    public override double DienTich() => this.Dai * this.Rong;
}
class HinhVuong : Hinh
{
    public double Canh { get; set; }
    public HinhVuong(double canh)
    {
        this.Canh = canh;
    }
    public override double ChuVi() => this.Canh * 4;
    public override double DienTich() => this.Canh * this.Canh;
}
