namespace QuattroDesignPatterns.Structural.Facade
{
    public class BluetoothSystem
    {
        public void ConnectPhone(string phoneName)
        {
            Console.WriteLine($"Connecting to phone {phoneName} via Bluetooth...");
        }
    }
}