using Microsoft.ML.Runtime.Api;

namespace MLModel
{
    public class IrisPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
}