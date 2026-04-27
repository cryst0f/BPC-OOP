using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CV12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpPost(Name = "Calculate")]
        public decimal Post([FromBody] CalcDTO calcDTO)
        {
            switch (calcDTO.Operation)
            {
                case "plus":
                    return calcDTO.Operand1 + calcDTO.Operand2;

                case "minus":
                    return calcDTO.Operand1 - calcDTO.Operand2;

                case "krat":
                    return calcDTO.Operand1 * calcDTO.Operand2;

                case "deleno":
                    if (calcDTO.Operand2 == 0)
                        throw new DivideByZeroException();
                    return calcDTO.Operand1 / calcDTO.Operand2;

                default:
                    throw new ArgumentException("Error. Neplatna operace");
            }
        }
    }
}
