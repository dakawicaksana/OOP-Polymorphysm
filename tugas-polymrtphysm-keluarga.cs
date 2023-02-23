using System;
using System.Linq;

namespace appkeluarga
{
	class Keluarga
	{
		public string Nama { get; set; }
		public int Umur { get; set; }
		public string Hobi { get; set; }
		public string Nomor { get; set; }

		public virtual void Informasi()
		{
			Console.WriteLine($"Nama = {Nama}");
			Console.WriteLine($"Umur = {Umur}");
			Console.WriteLine($"Hobi = {Hobi}");
			Console.WriteLine($"Nomor HP = {Nomor}");
		}
	}

	class Ayah : Keluarga
	{
		public string Pekerjaan { get; set; }

		public override void Informasi()
		{
			base.Informasi();
			Console.WriteLine($"Pekerjaan = {Pekerjaan}");
		}
	}

	class Ibu : Keluarga
	{
		public string Pekerjaan { get; set; }

		public override void Informasi()
		{
			base.Informasi();
			Console.WriteLine($"Pekerjaan = {Pekerjaan}");
		}
	}

	class Adik : Keluarga
	{
		public string Sekolah { get; set; }

		public override void Informasi()
		{
			base.Informasi();
			Console.WriteLine($"Sekolah = {Sekolah}");
		}
	}

	class Saya : Keluarga
	{
		public string Sekolah { get; set; }

		public override void Informasi()
		{
			base.Informasi();
			Console.WriteLine($"Sekolah = {Sekolah}");
		}
	}


	public static class Program
	{
		public static void Main()
		{
			Keluarga[] keluarga = new Keluarga[4];
			keluarga[0] = new Ayah { Nama = "Eko Hardiyono", Umur = 48, Pekerjaan = "Wirausaha", Hobi = "dengar musik", Nomor = "0812-3472-1757" };
			keluarga[1] = new Ibu { Nama = "Lailil Fauziah", Umur = 39, Pekerjaan = "Ibu rumah tangga", Hobi = "membaca", Nomor = "0858-5080-3527" };
			keluarga[2] = new Adik { Nama = "Guna Dharma", Umur = 7, Sekolah = "SD", Hobi = "Main puzzle" };
			keluarga[3] = new Saya { Nama = "Daka Wicaksana", Umur = 16, Sekolah = "SMK", Hobi = "Main Rubik", Nomor = "0857-2978-9212" };

			foreach (Keluarga anggota in keluarga)
			{
				anggota.Informasi();
				Console.WriteLine();
			}

		}
	}
}
