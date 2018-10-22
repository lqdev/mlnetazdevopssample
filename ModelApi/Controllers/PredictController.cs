using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MLModel;

namespace ModelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PredictController : ControllerBase
    {

        // POST api/predict
        [HttpPost]
        public async Task<ActionResult<string>> Post([FromBody] IrisData instance)
        {
            var model = await Model.LoadZipModel("model.zip");
            var prediction = Model.MakePrediction(model,instance);
            return Ok(prediction);
        }

    }
}
