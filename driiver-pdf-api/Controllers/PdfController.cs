using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace driiver_pdf_api.Controllers
{
    [ApiController]
    [Route("pdf")]
    public class PdfController: ControllerBase
    {
        public PdfController()
        {
        }

        [HttpGet]
        [Route("generate/{json}")]
        public Task<string> GeneratePDF(string json)
        {
            try
            {
                return Task.FromResult(json);
            } catch(Exception ex)
            {
                throw new Exception(ex.HelpLink, ex.InnerException);
            }
        }
    }
}
