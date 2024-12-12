using CamadaDeDados;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace CamadaDeNegocios
{
    public class FuncionarioRegraDeNegocio
    {
        private readonly FuncionarioDBContext _db = new FuncionarioDBContext();

        // Construtor para inicializar o contexto do banco de dados
        public FuncionarioRegraDeNegocio()
        {
            _db = new FuncionarioDBContext();
        }

        // Regra de negócio para adicionar um funcionário
        public void AddFuncionario(Funcionario funcionario)
        {
            _db.Funcionarios.Add(funcionario);
            _db.SaveChanges();
        }

        // Regra de negócio para listar todos funcionários
        public List<Funcionario> GetAllFuncionarios()
        {
            return _db.Funcionarios.ToList();
        }


        // Regra de negócio para obter funcionário pelo Id
        public Funcionario GetFuncionarioById(int id)
        {
            return _db.Funcionarios.FirstOrDefault(func => func.FuncionarioId == id);
        }

        // Regra de negócio para editar um funcionário
        public void EditarFuncionario(Funcionario funcionario)
        {
            var funcionarioExistente = _db.Funcionarios.FirstOrDefault(func => func.FuncionarioId == funcionario.FuncionarioId);

            if (funcionarioExistente != null)
            {
                funcionarioExistente.Nome = funcionario.Nome;
                funcionarioExistente.Genero = funcionario.Genero;
                funcionarioExistente.Cidade = funcionario.Cidade;
                funcionarioExistente.Salario = funcionario.Salario;
                funcionarioExistente.DataNascimento = funcionario.DataNascimento;

                _db.SaveChanges();
            }
        }

        public void DeletarFuncionario(int id)
        {
            var funcionario = _db.Funcionarios.FirstOrDefault(e => e.FuncionarioId == id);
            if (funcionario != null)
            {
                _db.Funcionarios.Remove(funcionario);
                _db.SaveChanges();
            }
        }

    }
}
 