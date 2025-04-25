class program
{
    static Rekening rekening = new Rekening("2095", "Hafidlul", 1000000);

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Layanan Digital Bank Pelita ===");
            Console.WriteLine("1. Lihat Data Rekening");
            Console.WriteLine("2. Setor Tunai");
            Console.WriteLine("3. Tarik Tunai");
            Console.WriteLine("-----------------------------------");
            Console.Write("Pilih menu: ");
            string pilihan = Console.ReadLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

            switch (pilihan)
            {
                case "1":
                    rekening.TampilkanInfo();
                    break;

                case "2":
                    Console.Write("Jumlah setor: ");
                    string inputSetor = Console.ReadLine();
                    decimal setor = decimal.Parse(inputSetor);
                    rekening.Setor(setor);
                    break;

                case "3":
                    Console.Write("Jumlah tarik: ");
                    string inputTarik = Console.ReadLine();
                    decimal tarik = decimal.Parse(inputTarik);
                    rekening.Tarik(tarik);
                    break;

                default:
                    Console.WriteLine("Menu tidak tersedia.");
                    break;
            }
        }
    }
}

class Rekening
{
    public string nomorRekening;
    public string namaPemilik;
    public decimal saldoRekening;

    public Rekening(string nomor, string nama, decimal saldo)
    {
        nomorRekening = nomor;
        namaPemilik = nama;
        saldoRekening = saldo;
    }
    public void TampilkanInfo()
    {
        Console.WriteLine("Nomor Rekening : " + nomorRekening);
        Console.WriteLine("Nama Pemilik   : " + namaPemilik);
        Console.WriteLine("Saldo Rekening : " + saldoRekening);
    }
    public void Tarik(decimal jumlah)
    {
        if (saldoRekening >= jumlah)
        {
            saldoRekening = saldoRekening - jumlah;
            Console.WriteLine("Selamat, penarikan berhasil");
        }
        else
        {
            Console.WriteLine("Saldo anda tidak mencukupi");
        }
    }

    public void Setor(decimal jumlah)
    {
        saldoRekening = saldoRekening + jumlah;
        Console.WriteLine("Selamat, setoran berhasil");
    }
}