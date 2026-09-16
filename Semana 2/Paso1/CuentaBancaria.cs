public class CuentaBancaria
{
    private string titular;
    private decimal saldo;

    public string Titular => titular;
    public decimal Saldo => saldo;

    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        this.titular = titular;
        saldo = saldoInicial;
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            saldo += monto;
        }
    }

    public bool Retirar(decimal monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            return true;
        }

        return false;
    }

    public bool Transferir(CuentaBancaria destino, decimal monto)
    {
        if (Retirar(monto))
        {
            destino.Depositar(monto);
            return true;
        }

        return false;
    }

    public void MostrarResumen()
    {
        System.Console.WriteLine($"Titular: {titular}");
        System.Console.WriteLine($"Saldo: {saldo:C}");
    }
}
