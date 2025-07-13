using JARVIS.Devices;

namespace JARVIS.Interfaces
{
    public interface ISamsungTvService
    {
        /// <summary>
        /// Initiates pairing & WebSocket connections to all configured TVs.
        /// </summary>
        Task ConnectAllAsync();

        /// <summary>
        /// Sends a single remote command to the TV identified by 'name'.
        /// </summary>
        Task SendCommandAsync(string name, RemoteCommand command);
    }
}
