// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





















/** THIS SECTION WAS USED TO TEST THE LIVINGROOM TV

using System;
using System.Threading.Tasks;
using JARVIS.Devices;


class Program
{
    
    static async Task Main()
    {
        var client = new SamsungTvClient("192.168.0.164", "JARVIS");

        // —— Connect once —— 
        await client.ConnectAsync();
        Console.WriteLine("✅ TV connected! Enter commands (VolumeUp, VolumeDown, etc.) or 'exit' to quit.");

        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine()?.Trim();
            if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (Enum.TryParse<RemoteCommand>(input, true, out var cmd))
            {
                try
                {
                    // —— Send on the already-open socket —— 
                    await client.SendCommandAsync(cmd);
                    Console.WriteLine($"✓ Sent {cmd}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"✗ Failed to send: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Unknown command '{input}'");
            }
        }
    } 
}**/
