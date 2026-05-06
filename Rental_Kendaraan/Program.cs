List<Kendaraan> data_kendaraan = new List<Kendaraan>()
{
    new Kendaraan("Vario", 125000, "N 4588 JY"),
    new Kendaraan("NMax", 150000, "B 6738 NB"),

};
while (true)
{
    Console.WriteLine("--Rental Murah Malang--");
    Console.WriteLine("\nDaftar kendaraan");

    foreach (var dk in data_kendaraan)
    {
        dk.tampilkanInfo();
    }

}
class Kendaraan
{
    //Field
    protected string _namakendaraan;
    protected double _hargaSewaPerHari;
    protected string _nomorPolisi;
    protected bool IsAvailable;

    public Kendaraan(string nama_kendaraan, double harga_Sewa, string nomor_Polisi)
    {
        //Constructor
        _namakendaraan = nama_kendaraan;
        _hargaSewaPerHari = harga_Sewa;
        _nomorPolisi = nomor_Polisi;
        IsAvailable = true;
    }

    //Propherty
    public string NamaKendaraan
    {
        get { return _namakendaraan; }
        set { _namakendaraan = value; }
    }
    public double HargaSewa
    {
        get { return _hargaSewaPerHari; }
        set
        {
            if (value > 0)
            {
                _hargaSewaPerHari = value;
            }
            else
            {
                Console.WriteLine("Harga sewa harus lebih besar dari 0.");
            }
        }
    }
    public string NomorPolisi
    {
        get { return _nomorPolisi; }
    }
    public bool isAvailable
    {
        get { return IsAvailable; }
    }

    public void tampilkanInfo()
    {
        Console.WriteLine($"Nama Kendaraan: {_namakendaraan}");
        Console.WriteLine($"Harga Sewa Per Hari: {_hargaSewaPerHari}");
        Console.WriteLine($"Nomor Polisi: {_nomorPolisi}");
        Console.WriteLine($"Ketersediaan: {(IsAvailable ? "Tersedia" : "Tidak Tersedia")}");
    }

    public void ubahStatus()
    {
        IsAvailable = !IsAvailable;
    }
    public virtual double hitungTotal(int jumlahhari)
    {
        return _hargaSewaPerHari * jumlahhari;
    }
}

class Mobil : Kendaraan
{
    private double _biayaAsuransi;
    public Mobil(string nama_Kendaraan, double harga_Sewa, string nomer_Polisi)
        : base(nama_Kendaraan, harga_Sewa, nomer_Polisi)
    {
        _biayaAsuransi = 50000;
    }
    public override double hitungTotal(int jumlahhari)
    {
        return base.hitungTotal(jumlahhari) + _biayaAsuransi;
    }
}

class MiniBus : Kendaraan
{
    private double _biayaSopir;
    public MiniBus(string nama_kendaraan, double harga_sewa, string nomer_Polisi)
        : base(nama_kendaraan, harga_sewa, nomer_Polisi)
    {
        _biayaSopir = 100000;
    }
    public override double hitungTotal(int jumlahhari)
    {
        return base.hitungTotal(jumlahhari) * _biayaSopir;
    }

}