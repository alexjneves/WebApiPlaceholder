using System.Collections.Generic;
using Placeholder.Data;

namespace Placeholder.Storage.InMemory
{
    public class InMemoryPlaceholderStorage : IPlaceholderStorage
    {
        private readonly List<PlaceholderData> _placeholderData; 

        public List<PlaceholderData> PlaceholderData { get { return _placeholderData; } }

        public InMemoryPlaceholderStorage()
        {
            _placeholderData = new List<PlaceholderData>
            {
                new PlaceholderData { StringData = "Example1", IntData = 1 },
                new PlaceholderData { StringData = "Example2", IntData = 2 },
            };
        }

        public bool AddPlaceholderData(PlaceholderData newData)
        {
            PlaceholderData.Add(newData);
            return true;
        }
    }
}
