using Netmavryk.Forging.Models;

namespace Netmavryk.Forging
{
    public interface IForge
    {
        Task<byte[]> ForgeOperationAsync(string branch, OperationContent content);

        Task<byte[]> ForgeOperationGroupAsync(string branch, IEnumerable<ManagerOperationContent> contents);
    }
}
