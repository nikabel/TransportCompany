using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportCompany.models
{
    public class TransportModel
    {
        private string _modelName;
        private string _markName;
        private int _modelCount;

        public TransportModel(string modelName, string markName, int modelCount)
        {
            ModelName = modelName;
            MarkName = markName;
            ModelCount = modelCount;
        }

        public string ModelName { get => _modelName; set => _modelName = value; }
        public string MarkName { get => _markName; set => _markName = value; }
        public int ModelCount { get => _modelCount; set => _modelCount = value; }
    }
}
