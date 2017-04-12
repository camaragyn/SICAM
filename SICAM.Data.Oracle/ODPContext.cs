using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SICAM.Data.Oracle
{
    /// <summary>
    /// Classe de contexto de acesso ao Oracle
    /// </summary>
    public class ODPContext : DbContext
    {
        /// <summary>
        /// Metodo contrutor do contexto onde é passado o nome da connectionstring, que fica 
        /// no arquivo de configuração do projeto
        /// </summary>
        public ODPContext() : base("ODPContext") { }

        /// <summary>
        /// Método sobrescrito para configurações de relacionamentos e
        /// no caso do Oracle, é obrigatório informar o nome do schema
        /// ou usuário do Oracle
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("CAMARA");
        }
    }
}
