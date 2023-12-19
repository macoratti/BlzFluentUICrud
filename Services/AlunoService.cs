using BlzFluentUICrud.Context;
using BlzFluentUICrud.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlzFluentUICrud.Services;

public class AlunoService : IAlunoService
{
    private readonly AppDbContext _context;

    public AlunoService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Aluno> GetAluno(int? id)
    {
        var aluno = await _context.Alunos.FirstOrDefaultAsync(a => a.Id == id);
        return aluno ?? new Aluno();

        //if (aluno == null)
        //{
        //    throw new EntityNotFoundException($"Aluno com ID {id} não encontrado.");
        //}
    }

    public async Task<List<Aluno>> GetAlunos()
    {
        return await _context.Alunos.ToListAsync();
    }
    public async Task<Aluno> AddAluno(Aluno aluno)
    {
        if(aluno is null)
            throw new ArgumentNullException(nameof(aluno));

        _context.Add(aluno);
        await _context.SaveChangesAsync();
        return aluno;
    }
    public async Task<Aluno> UpdateAluno(Aluno aluno)
    {
        if (aluno is null)
            throw new ArgumentNullException(nameof(aluno));

        //_context.Update(aluno);
        //await _context.SaveChangesAsync();
        //return aluno;

        _context.Entry(aluno).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return aluno;
    }
    public async Task<Aluno> DeleteAluno(int id)
    {
        var aluno = await _context.Alunos.FirstOrDefaultAsync(a => a.Id == id);

        if (aluno == null)
        {
            throw new EntityNotFoundException($"Aluno com ID {id} não encontrado.");
        }

        _context.Alunos.Remove(aluno);
        await _context.SaveChangesAsync();

        return aluno;
    }
}
