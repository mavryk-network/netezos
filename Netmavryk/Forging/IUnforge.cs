using Netmavryk.Forging.Models;

namespace Netmavryk.Forging
{
    public interface IUnforge
    {
        Task<(string, IEnumerable<OperationContent>)> UnforgeOperationAsync(byte[] content);
    }
}
