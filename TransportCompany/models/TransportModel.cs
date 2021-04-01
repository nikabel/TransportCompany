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
        private string _modelDesc;
        private int _modelCount;

        public TransportModel(string modelName, string markName, string modelDesc, int modelCount)
        {
            ModelName = modelName;
            MarkName = markName;
            ModelDesc = modelDesc;
            ModelCount = modelCount;
        }

        public string ModelName { get => _modelName; set => _modelName = value; }
        public string MarkName { get => _markName; set => _markName = value; }
        public string ModelDesc { get => _modelDesc; set => _modelDesc = value; }
        public int ModelCount { get => _modelCount; set => _modelCount = value; }
    }
}
