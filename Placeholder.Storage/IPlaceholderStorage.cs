using System.Collections.Generic;
using Placeholder.Data;

namespace Placeholder.Storage
{
    public interface IPlaceholderStorage
    {
        List<PlaceholderData> PlaceholderData { get; }
        bool AddPlaceholderData(PlaceholderData newData);
    }
}
