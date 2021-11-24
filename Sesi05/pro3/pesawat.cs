using System;

public class pesawat
{
    public string Nama;
    public string Ketinggian;
    public string JumlahPenumpang;
    public int JumlahRoda;

    public void terbang()
    {
        Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.Nama);
    }


}
class pesawat_tempur : pesawat
{
    public void terbangtinggi()
    {
        Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa sejumlah penumpang sebanyak {3}, akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
}