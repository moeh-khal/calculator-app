class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Consol.Writeline("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Consol.Writeline("Hasil Penambahan: {0} - {1} = {2}", a, b, Pengurangan, b));
		
		Cosole.Writeline("\n Tekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	statuic int Pengurangan(int a, int b)
	{
		return a - b;
	}
}