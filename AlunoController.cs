[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private static List<Aluno> alunos = new List<Aluno>();

    [HttpPost]
    public IActionResult CriarAluno([FromBody] Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }

        alunos.Add(aluno);
        return Ok(aluno);
    }
}
