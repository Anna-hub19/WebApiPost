using Microsoft.Extensions.Configuration;
using Npgsql;
using PocPostegress.Domain.Domain;
using PocPostgress.DataBase.DataBase;
using PocPostgress.Repository.Repositorios.Interfaces;


namespace PocPostgress.Repository.Repositorios
{
    public class AlunosRepositorio : IAdicionarAlunosRepository
    {
        private ConnectionDB _connectionDB;
        public AlunosRepositorio(IConfiguration configuration)
        {
            _connectionDB = new ConnectionDB(configuration);
        }

        public async Task<bool> AdicionarAlunosAsync(Aluno aluno)
        {
            string query = "INSERT INTO aluno (Nome, Idade) VALUES (@Nome, @Idade)";

            // Criar a conexão usando a string de conexão
            using (var connection = new NpgsqlConnection(_connectionDB.GetString()))
            {
                await connection.OpenAsync(); // Abrir a conexão

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", aluno.Nome);
                    command.Parameters.AddWithValue("@Idade", aluno.Idade);

                    try
                    {
                        await command.ExecuteNonQueryAsync();
                        return true; // Inserção bem-sucedida
                    }
                    catch (Exception ex)
                    {
                        // Logar ou imprimir o erro
                        Console.WriteLine($"Erro ao inserir aluno: {ex.Message}");
                        return false; 
                    }
                    finally
                    {
                        connection.Close(); 
                    }
                }
                
            }
                
              
           
        }

      
    }
}

  
