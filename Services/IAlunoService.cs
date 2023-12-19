using BlzFluentUICrud.Entities;

namespace BlzFluentUICrud.Services;

public interface IAlunoService
{
    Task<List<Aluno>> GetAlunos();
    Task<Aluno> GetAluno(int? id);
    Task<Aluno> AddAluno(Aluno aluno);
    Task<Aluno> UpdateAluno(Aluno aluno);
    Task<Aluno> DeleteAluno(int id);
}
