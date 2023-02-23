using System;

public class HelloWorld
{
	static public void Main()
	{
		
		familyhobi family = new familyhobi();
		familyhobi ayah = new Ayah();
		familyhobi ibu = new Ibu();
		familyhobi saya = new Saya();
		familyhobi adik = new Adik();

		familydata ayahku = new familydata("Eko Hardiyono", 46, +6281234721757);
		familydata ibuku = new familydata("Lailil Fauziah", 38, +6285850803527);
		familydata aku = new familydata("Daka Wicaksana", 16, +6285729789212);
		familydata adikku = new familydata("Guna Dharma", 7, 0);


		Console.WriteLine("data ayah:\n" + ayahku.nama + "\n" + ayahku.umur + "\n" + ayahku.nohp);
		ayah.Hobi();
		Console.WriteLine();
		
		Console.WriteLine("data ibu:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp);
		ibu.Hobi();
		Console.WriteLine();
		
		Console.WriteLine("data saya:\n" + aku.nama + "\n" + aku.umur + "\n" + aku.nohp);
		saya.Hobi();
		Console.WriteLine();
		
		Console.WriteLine("data adik:\n" + adikku.nama + "\n" + adikku.umur + "\n" + adikku.nohp);
		adik.Hobi();

	}
	
	class familydata
	{
		public string nama;
		public int umur;
		public long nohp;

		public familydata(string Nama, int Umur, long Nohp)
		{
			nama = Nama;
			umur = Umur;
			nohp = Nohp;
		}
	}
	
	class familyhobi
	{
		public virtual void Hobi()
		{
			Console.WriteLine("Hobi");
		}
	}
	
	class Ayah : familyhobi
	{
		public override void Hobi()
		{
			Console.WriteLine("mendengarkan musik");
		}
	}
	
	class Ibu : familyhobi
	{
		public override void Hobi()
		{
			Console.WriteLine("membaca");
		}
	}
	
	class Saya : familyhobi
	{
		public override void Hobi()
		{
			Console.WriteLine("main rubik");
		}
	}
	
	class Adik : familyhobi
	{
		public override void Hobi()
		{
			Console.WriteLine("main puzzle");
		}
	}

}
