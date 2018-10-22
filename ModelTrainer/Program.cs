using System;
using MLModel;

namespace ModelTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = "data/iris.txt";
            string modelPath = "model.zip";

            Model.TrainModel(dataPath,modelPath);
        }
    }
}
